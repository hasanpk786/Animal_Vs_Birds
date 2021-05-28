using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyAI : MonoBehaviour
{

    public Transform target;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;

    public Transform enemyGFX;

    Path path;
    int currentWayPoint = 0;
    bool reachedEndofPath = false;

    Seeker seeker;
    Rigidbody2D rb;
    static int counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);
    }

    void UpdatePath()
    {
        if(seeker.IsDone())
           seeker.StartPath(rb.position, target.position, OnpathComplete);
    }

    void OnpathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWayPoint = 0;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
    
        if(target == null)
        {
            counter++;
            string a = " (";
            string b = counter.ToString();
            string c = ")";

            string d = "Food" + a + b + c;
            
            Debug.Log(d);
            target = GameObject.Find(d).transform;
        }

        if (path == null)
            return;

        if(currentWayPoint >= path.vectorPath.Count)
        {
            reachedEndofPath = true;
            return;
        }
        else
        {
            reachedEndofPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWayPoint] - rb.position).normalized;
       
        Debug.Log("DONT GO LEFT!"+rb.position);
        Debug.Log("DONT GO LEFT2!" + (Vector2)path.vectorPath[currentWayPoint]);
        Debug.Log("DONT GO LEFT3!" + direction);
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPoint]);

        if(distance < nextWaypointDistance)
        {
            currentWayPoint++;
        }

        if (force.x >= 0.01f)
        {

            enemyGFX.localScale = new Vector3(-0.07f, 0.07f, 0f);
        }
        else if (force.x <= -0.01f)
        {
            enemyGFX.localScale = new Vector3(0.07f, 0.07f, 0f);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aipath;

    // Update is called once per frame
    void Update()
    {
        if(aipath.desiredVelocity.x >= 0.01f)
        {
           transform.localScale = new Vector3(-0.3f, 0.35f, 0f);
        }
        else if(aipath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(0.3f, 0.35f, 1f);
        }
    }

    /*
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
    */
}

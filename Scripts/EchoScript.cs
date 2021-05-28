using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoScript : MonoBehaviour
{
    public Joystick joystick;
    float timeSpawns;
    public float StartTime;
    public GameObject echo;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || (joystick.Horizontal >= .2f) || (joystick.Horizontal <= -.2f))
            if (timeSpawns <= 0)
            {
                GameObject Temp = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(Temp, 1f);
                timeSpawns = StartTime;
            }
            else
            {
                timeSpawns -= Time.deltaTime;
            }
        
    }
}

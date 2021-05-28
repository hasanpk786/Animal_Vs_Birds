using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Open_to_Close : MonoBehaviour
{
    private bool open;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Instantiate
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("r"))
        {
            open = !open;
        }
        if (!open)
        {
           
        }
    }
}

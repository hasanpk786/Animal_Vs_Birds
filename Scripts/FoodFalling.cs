using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFalling : MonoBehaviour
{
    public GameObject apple;
    private Vector2 v;
    private Vector2 screenBounds;
    Vector2 spawnpos;
    float this_x;
    float this_y;

    // Start is called before the first frame update
    void Start()
    {
        this_x = this.GetComponent<Transform>().position.x;
        this_y = this.GetComponent<Transform>().position.y;
        spawnpos = this.GetComponent<Transform>().position;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log(screenBounds);
    }
    
    //Spawns food at this GameObejects position
    void SpawnFood(Vector2 pos)
    {
        //If game is paused do not spawn food
        if (Time.timeScale == 0f) {
            return;
        }
        
        GameObject a = Instantiate(apple);
        a.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        /*If Mouse is clicked on the window object then spawn food*/
        if ((v.x == this_x) && (v.y == this_y))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                
                SpawnFood(spawnpos);
                //change coordinate to only spawn food once when clicked once
                v.x = -999;
            }
        }
    }
    
    private void OnMouseDown()
    {
        //Gets the position of where the mouse clicked; if it has clicked this object then x and y are same
        v = transform.position;
    }

}

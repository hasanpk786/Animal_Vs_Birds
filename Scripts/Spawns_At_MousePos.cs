using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns_At_MousePos : MonoBehaviour
{
    public GameObject apple;
    private Vector2 screenBounds;
    int limit = 5;
    int timer = 0;
    
    float WinOne_x1;
    float WinOne_x2;
    float WinOne_y1;
    float WinOne_y2;
    Vector2 Spawn_1;
    int limiter_1;

    float WinTwo_x1;
    float WinTwo_x2;
    float WinTwo_y1;
    float WinTwo_y2;
    Vector2 Spawn_2;
    int limiter_2;

   /* float WinThree_x1;
    float WinThree_x2;
    float WinThree_y1;
    float WinThree_y2;
    Vector2 Spawn_3;
    int limiter_3;*/

    float WinFour_x1;
    float WinFour_x2;
    float WinFour_y1;
    float WinFour_y2;
    Vector2 Spawn_4;
    int limiter_4;



    // Start is called before the first frame update
    void Start()
    {
        limiter_1 = 0;
        limiter_2 = 0;
        //limiter_3 = 0;
        limiter_4 = 0;

        WinOne_x1 = -5f;
        WinOne_y1 = 0f;
        WinOne_x2 = -4.7f;
        WinOne_y2 = -0.2f;
        
        WinTwo_x1 = -6f;
        WinTwo_y1 = 1f;
        WinTwo_x2 = -4.9f;
        WinTwo_y2 = -1f;

       /* WinThree_x1 = -4f;
        WinThree_y1 = 4f;
        WinThree_x2 = -2.9f;
        WinThree_y2 = 2f;*/

        WinFour_x1 = -4f;
        WinFour_y1 = 1f;
        WinFour_x2 = -2.9f;
        WinFour_y2 = -1f;


        Spawn_1.x = -4.8f;
        Spawn_1.y = -0.1f;

        Spawn_2.x = -5.5f;
        Spawn_2.y = 0f;

       /* Spawn_1.x = -3.5f;
        Spawn_1.y = 3f;*/

        Spawn_4.x = -3.5f;
        Spawn_4.y = 0f;


        //spawnpos = this.GetComponent<Transform>().position;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log(screenBounds);

        //Vector3 Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    //Spawns food at this GameObejects position
    void SpawnFood(Vector2 pos)
    {
        //Instantiate(GameObject.Find("Food")).transform.position = pos;
        if (Time.timeScale == 0f)
        {
            return;
        }
        /*GameObject a = Instantiate(apple);
        a.transform.position = pos;*/
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer >= 25)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                //gets Mouse position relative to game world. Thus we can use a range to spawn food at that location
                //We can then just add this script to the camera maybe and have more than one position to check for foods
                Vector3 Mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Mouseposition.z = 0;
                //Debug.Log(Mouseposition);
                Check_To_Spawn();
                timer = 0;
                //seems better to limit the number of apples rather than delaying them
                //Invoke("Check_To_Spawn",0.5f);
            }
        }
    }

    void Check_To_Spawn()
    {
        Vector3 Mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Mousepos.z = 0;
        //window 1
        if ((Mousepos.x > WinOne_x1 && Mousepos.x < WinOne_x2)
            && (Mousepos.y < WinOne_y1 && Mousepos.y > WinOne_y2))
        {
            if (limiter_1 < limit)
            {
                limiter_1++;
                SpawnFood(Spawn_1);
            }
        }
        //window 2
        /*if ((Mousepos.x > WinTwo_x1 && Mousepos.x < WinTwo_x2)
            && (Mousepos.y < WinTwo_y1 && Mousepos.y > WinTwo_y2))
        {
            if (limiter_2 < limit)
            {
                limiter_2++;
                SpawnFood(Spawn_2);
            }
        }*/
        //window 3
        /*if ((Mousepos.x > WinThree_x1 && Mousepos.x < WinThreex2)
            && (Mousepos.y < WinThree_y1 && Mousepos.y > WinThree_y2))
        {
            if (limiter_3 < limit)
            {
                limiter_3++;
                SpawnFood(Spawn_3);
            }
        }*/

        //window 4
       /* if ((Mousepos.x > WinFour_x1 && Mousepos.x < WinFour_x2)
            && (Mousepos.y < WinFour_y1 && Mousepos.y > WinFour_y2))
        {
            if (limiter_4 < limit)
            {
                limiter_4++;
                SpawnFood(Spawn_4);
            }
        }*/
    }


    /*IEnumerator Spawn(Vector2 pos)
    {
        yield return new WaitForSeconds(1f);


    }*/

}


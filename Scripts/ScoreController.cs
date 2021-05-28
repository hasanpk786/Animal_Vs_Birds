using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreController : MonoBehaviour
{
    public static int counter = 0; 
    public static int counter_2 = 0;
    public TextMeshProUGUI[] c; //used to get all textmesh objects in an array
    public TextMeshProUGUI Cr,Rh; // get the objects from the array and store them in separate variables;
    //This allows two separate score counters to work properly; An alternative is to just use unity's basic text field
    

    // Start is called before the first frame update
    void Start()
    {
        c = FindObjectsOfType<TextMeshProUGUI>();
        Cr = c[1];
        Rh = c[0];
        //c[0] cat;  c[1] crow;

      /*  Debug.Log(Cr.name);
        Debug.Log("TEST");
        Debug.Log(Rh.name);*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<AudioManagerScript>().Play("Eat");

        if (collision.name == "EnemyBird" || collision.name == "Crow")
        {
            Debug.Log("We hit em boys");
            Debug.Log(collision.name);
            counter = counter+1;
            Cr.SetText(counter.ToString());
            Destroy(this.gameObject);
        }
        if(collision.name == "Rhino")
        {
            Debug.Log("We SCORED");
            Debug.Log(collision.name);
            counter_2++;
            Rh.SetText(counter_2.ToString());
            Destroy(this.gameObject);
            
        }
    }
}

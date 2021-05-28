using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject rhino;
    public GameObject EnemyBird;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rhino.GetComponent<Renderer>().enabled = false;
            rhino.transform.position = new Vector3 (-1.17f, -3f, 0 );
            rhino.GetComponent<Renderer>().enabled = true;
        }

    }
}

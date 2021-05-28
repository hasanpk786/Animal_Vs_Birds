using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    public float moveSpeed;
    public bool MoveRight;
    private float randomSpeed;

    private Rigidbody2D crow;
    void Start()
    {
        randomSpeed = Random.Range(0.8f, 1.5f);
        moveSpeed = randomSpeed;
        Debug.Log(moveSpeed);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (MoveRight)
            transform.Translate(2 * Time.deltaTime * moveSpeed, 0, 0);
        else
            transform.Translate(-2 * Time.deltaTime * moveSpeed, 0, 0);
    }

}

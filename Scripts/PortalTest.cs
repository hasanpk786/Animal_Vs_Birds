using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTest : MonoBehaviour
{
    private Rigidbody2D enteredRigidbody;
    private float enterVelocity, exitVelocity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enteredRigidbody = collision.gameObject.GetComponent<Rigidbody2D>();
        enterVelocity = enteredRigidbody.velocity.x;

        if (gameObject.name == "YellowPortal")
        {
            PortalControlTest.portalControlInstance.DisableCollider("red");
            PortalControlTest.portalControlInstance.CreateClone("atRed");
        }
        else if (gameObject.name == "RedPortal")
        {
            PortalControlTest.portalControlInstance.DisableCollider("yellow");
            PortalControlTest.portalControlInstance.CreateClone("atYellow");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        exitVelocity = enteredRigidbody.velocity.x;

        if (enterVelocity != exitVelocity)
        {
            Destroy(GameObject.Find("Clone"));
        }
        else if (gameObject.name != "Clone")
        {
            Destroy(collision.gameObject);
            PortalControlTest.portalControlInstance.EnableColliders();
            GameObject.Find("Clone").name = "Character";
        }
    }
}

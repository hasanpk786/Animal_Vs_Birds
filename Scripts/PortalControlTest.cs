using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalControlTest : MonoBehaviour
{
    public static PortalControlTest portalControlInstance;

    [SerializeField]
    private GameObject yellowPortal, redPortal;

    [SerializeField]
    private Transform yellowPortalSpawnPoint, redPortalSpawnPoint;

    private Collider2D yellowPortalCollider, redPortalCollider;

    [SerializeField]
    private GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        portalControlInstance = this;
        yellowPortalCollider = yellowPortal.GetComponent<Collider2D>();
        redPortalCollider = redPortal.GetComponent<Collider2D>();
    }
    public void CreateClone(string whereToCreate)
    {
        if (whereToCreate == "atYellow")
        {
            var instantiatedClone = Instantiate(clone, yellowPortalSpawnPoint.position, Quaternion.identity);
            instantiatedClone.gameObject.name = "Clone";

        }

        else if (whereToCreate == "atRed")
        {
            var instantiatedClone = Instantiate(clone, redPortalSpawnPoint.position, Quaternion.identity);
            instantiatedClone.gameObject.name = "Clone";

        }
    }
    public void DisableCollider(string collidertoDisable)
    {
        if (collidertoDisable == "red")
        {
            redPortalCollider.enabled = false;
        }
        else if (collidertoDisable == "yellow")
        {
            yellowPortalCollider.enabled = false;
        }
    }
    public void EnableColliders()
    {
        redPortalCollider.enabled = true;
        yellowPortalCollider.enabled = true;
    }
}

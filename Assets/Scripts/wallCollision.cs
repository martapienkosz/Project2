using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollision : MonoBehaviour
{
    public bool planetcnt = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Camera")
        {
            planetcnt = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public GameObject Door;
    public float cntPlatform3;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Door.SetActive(false);
            cntPlatform3 = 1.0f;
        }
    }
}


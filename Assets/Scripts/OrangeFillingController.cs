using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeFillingController : MonoBehaviour
{
    public GameObject orangeboxfilling;
    public float cntOrange;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueBall"))
        {
            Debug.Log("isTrue");
            orangeboxfilling.SetActive(false);
            cntOrange = 1.0f;
        }
    }
}


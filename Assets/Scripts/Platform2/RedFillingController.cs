using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFillingController : MonoBehaviour
{
    public GameObject redboxfilling;
    public float cntRed;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GreenBall"))
        {
            Debug.Log("isTrue");
            redboxfilling.SetActive(false);
            cntRed = 1.0f;
        }
    }
}

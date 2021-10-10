using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleFillingControler : MonoBehaviour
{
    public GameObject purpleboxfilling;
    public float cntPurple;

    public void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("YellowBall"))
        {
            Debug.Log("isTrue");
            purpleboxfilling.SetActive(false);
            cntPurple = 1.0f;
        }
    }
}

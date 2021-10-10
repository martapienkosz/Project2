using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleFillingController : MonoBehaviour
{
    public GameObject boxfilling;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("YellowBall"))
        {
            boxfilling.SetActive(false);
        }
    }

}

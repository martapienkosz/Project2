using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColors : MonoBehaviour
{
    ColorManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Camera"))
        {
            manager.TransitionColors();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public GameObject Door;
    public float cntPlatform3;
    public ColorManager manager;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Door.SetActive(false);
            cntPlatform3 = 1.0f;
            //manager.transition = Mathf.Clamp( manager.transition +  Time.deltaTime, 0.0f, 1.0f);
            manager.TransitionColors();

            SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Win);
        }
    }
}


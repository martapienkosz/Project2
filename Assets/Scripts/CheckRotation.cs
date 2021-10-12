using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRotation : MonoBehaviour
{
    private GameObject cylinder;

    private Vector3 currentDeg;

    public RotationFixtureRotateUpdateEvent colorUpdate = new RotationFixtureRotateUpdateEvent();

    [HideInInspector]
    public float angle;

    Vector3 startAngle = Vector3.zero;

    //float currentAngle;

   
    Coroutine colorCoroutine;

    //convert a world rotation to the local rotaion of this object
    Quaternion GetLocalRotation(Quaternion world)
    {
        return Quaternion.Inverse(world) * transform.localRotation;
    }

    void StartCheck()
    {
        if (colorCoroutine != null) StopCoroutine(colorCoroutine);
        colorCoroutine = StartCoroutine(CheckAngle());
    }

    void EndCheck()
    {
        if (colorCoroutine != null) StopCoroutine(colorCoroutine);
        startAngle = Vector3.zero;
        colorCoroutine = null;
    }

    IEnumerator CheckAngle()
    {
        //run this coroutine while the interactor is in use
        while (true)
        {
            //the current rotation angle is the delta from where we started to where we are now
            angle = GetLocalRotation(transform.rotation).eulerAngles.y;

            //currentAngle = angle/(2 * Mathf.PI);

            //if(currentAngle > 110 && currentAngle < 150)
            //{
                colorUpdate?.Invoke(angle);
        
            
            yield return null; //yield control back, so we pick up the next loop iteration in the next frame
        }
    }


}

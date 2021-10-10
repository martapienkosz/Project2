using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveThirdPlatform : MonoBehaviour
{
    public Vector3 start = Vector3.zero;
    public Vector3 end = Vector3.zero;
    public float duration = 8;

    public OrangeFillingController orange;
    public PurpleFillingControler purple;
    public RedFillingController red;

    float currentT = 0;
    bool movePlatform = false;
    AnimationCurve curve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
        currentT = 0;
        transform.position = start;
    }

    // Update is called once per frame
    void Update()
    {
        if (red.cntRed == 1.0f && orange.cntOrange == 1.0f && purple.cntPurple == 1.0f)
        {
            movePlatform = true;
            Debug.Log("MOVE");
        }

        if (movePlatform == true)
        {
            if (transform.position != end)
            {
                currentT += Time.deltaTime / duration;
                currentT = Mathf.Clamp01(currentT);
                transform.position = Vector3.Lerp(start, end, curve.Evaluate(currentT));
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderColorManager : MonoBehaviour
{
    public Color highlightColor;

    private GameObject cylinder;

    MeshRenderer meshRenderer;
    Color baseColor;

    Vector3 axis = new Vector3(0, 1, 0);
    float offset = 0;
    float currentAngle = 0;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    //gets the color of the cube
    public Color GetBaseColor()
    {
        return baseColor;
    }

    public void SetBaseColor(Color c)
    {
        baseColor = c;
        meshRenderer.material.color = baseColor;
    }

    public void Highlight()
    {
        
            meshRenderer.material.color = highlightColor;
    }

    public void ClearHighlight()
    {
        meshRenderer.material.color = baseColor;
    }
}

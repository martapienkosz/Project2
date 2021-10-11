using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTimeOut : MonoBehaviour
{
    public Transform spawnBlue;
    public Transform spawnGreen;
    public Transform spawnYellow;

    public GameObject blueball;
    public GameObject greenball;
    public GameObject yellowball;


    private void Update()
    {
        if(blueball.transform.position.y < 0)
        {
            blueball.transform.position = spawnBlue.position;
        }

        if (greenball.transform.position.y < 0)
        {
            greenball.transform.position = spawnGreen.position;
        }

        if (yellowball.transform.position.y < 0)
        {
            yellowball.transform.position = spawnYellow.position;
        }
    }
}

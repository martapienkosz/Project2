using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
        Vector3 axis = new Vector3(0, 1, 0);

        float offset = 0;

        public void StartTurn()
        {
            transform.localRotation.ToAngleAxis(out offset, out Vector3 axis);
        }

        public void Turn(float angle)
        {
            transform.localRotation = Quaternion.AngleAxis(offset + angle, axis);
        }
}

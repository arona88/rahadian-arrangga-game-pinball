using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerzoomincontroller : MonoBehaviour
{
    public Collider sphere;
    public CameraController cameracontroller;
        public float length;

    private void OnTriggerEnter(Collider other)
    {
        if (other == sphere)
        {
            cameracontroller.FollowTarget(sphere.transform, length);
        }
    }
}

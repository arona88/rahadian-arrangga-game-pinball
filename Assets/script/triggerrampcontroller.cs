using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerrampcontroller : MonoBehaviour
{
    public Collider sphere;
    public scoremanager scoremanager;

    public float score;

    private void OnTriggerEnter(Collider other)
    {
        if (other == sphere)
        {
            scoremanager.AddScore(score);
        }
    }
}
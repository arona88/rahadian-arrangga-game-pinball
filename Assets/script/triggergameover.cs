using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public Collider sphere;
    public GameObject gameovercanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == sphere)
        {
            gameovercanvas.SetActive(true);
        }
    }
}

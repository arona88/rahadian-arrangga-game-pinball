using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public float score;

    private void Start()
    {
        ResetScore();
    }

    public void AddScore(float addition)
    {
        score += addition;
    }

    public void ResetScore()
    {
        score = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXmanager : MonoBehaviour
{
    public GameObject vfxAudioSource;


    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumeer : MonoBehaviour
{
    public Collider sphere;
    public float multiplier;
    public Color color;
    public float score;

    public audio audio;
    public VFXmanager vfxmanager;
    public scoremanager scoremanager; 

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == sphere)
        {
            Rigidbody sphereRig = sphere.GetComponent<Rigidbody>();
            sphereRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            audio.PlaySFX(collision.transform.position);

            vfxmanager.PlayVFX(collision.transform.position);

            scoremanager.AddScore(score);
        }
    }
}

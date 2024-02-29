using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Collider bola;
    public float multiplier;


    public float score;
    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private Animator animator;
    private void Start()
    {
       animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //Play Animasi
            animator.SetTrigger("Hit");

            //PlaySFX
            audioManager.PlaySFXBumper(collision.transform.position);

            //PlayVFX
            vfxManager.PlayVFXBumper(collision.transform.position);

            //Score add
            scoreManager.AddScore(score);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject Win;
    public AudioSource FinishSound;
    public ParticleSystem FinishParticleSystem;

    void Start()
    {
        FinishSound = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        FinishSound.Play();
        FinishParticleSystem.Play();
        Win.SetActive(true);
    }
}

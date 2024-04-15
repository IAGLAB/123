using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeEffect : MonoBehaviour
{
    public ParticleSystem smokeParticles;

    void Start()
    {
        smokeParticles.Play();
    }
}
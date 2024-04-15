using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemCharacter : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(h, v, 0);
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
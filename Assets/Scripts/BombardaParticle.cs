using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombardaParticle : MonoBehaviour
{
    public ParticleSystem bombardaParticle;
            
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            bombardaParticle.transform.position = transform.position;
            bombardaParticle.Play();
        }
    }
}

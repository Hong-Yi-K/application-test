using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public PlayerLife pHealth;
    public float damage;

    public AudioSource spikeSound;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide with" + gameObject.tag);


        if (collision.gameObject.CompareTag("Spike"))
        {
            spikeSound.Play();
            pHealth.health -= damage;
        }
    }
}


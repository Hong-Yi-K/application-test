using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public PlayerHealth pHealth;
    public float damage;
    public AudioSource spikeSound;

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide with" + gameObject.tag);


        if (other.gameObject.CompareTag("Player"))
        {
            spikeSound.Play();
            pHealth.health -= damage;
        }
    }
}

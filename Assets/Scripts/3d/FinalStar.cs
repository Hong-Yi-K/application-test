using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinalStar : MonoBehaviour
{

    public AudioSource collectSound;

    [SerializeField]
    private GameObject victoryScene;

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.StarsCollected();
            collectSound.Play();
            victoryScene.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}

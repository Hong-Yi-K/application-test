using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public AudioSource collectSound;
    public AudioSource tadaSound;
    [SerializeField]
    private GameObject victoryScene;

    private int coins = 0;
    public TextMeshProUGUI coinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = ""+ coins;
            collectSound.Play();
            Debug.Log("Coins: " + coins);

            if (coins == 6)
            {
                tadaSound.Play();
                victoryScene.SetActive(true);
            }
        }
    }

}

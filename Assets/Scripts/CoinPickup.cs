using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public TMP_Text coinUICounter;
    private int coinsCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check to see if the game object I collided with is tagged as a "Coin"
        if (collision.gameObject.tag == "Coin")
        {
            // Okay, we have collided with a Coin

            // Increment the number of coins we have collected
            coinsCollected++;

            // Destroy the coin
            Destroy(collision.gameObject);

            // Update the UI
            coinUICounter.text = "Coins collected: " + coinsCollected;
        }
    }
}

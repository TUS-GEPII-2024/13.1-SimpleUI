using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthMonitor : MonoBehaviour
{
    public Slider healthSlider;
    private int health = 10;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blade")
        {
            health--;
            healthSlider.value = health;

            if (health == 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}

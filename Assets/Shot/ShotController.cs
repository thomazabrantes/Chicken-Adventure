using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")) {
            Destroy(collision.gameObject); // Destroy the enemy on collision with the shot
            Destroy(gameObject); // Destroy the shot after hitting the enemy

            FindObjectOfType<SoundFXController>().PlayEnemyDeath(); // Play enemy death sound
        }
    }
}

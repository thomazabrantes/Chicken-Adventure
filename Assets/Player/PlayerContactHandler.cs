using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System; // Import the SceneManagement namespace to manage scenes

public class PlayerContactHandler : MonoBehaviour
{

    public String nextLevelName = "Level 1";

    public Image itemImage;

    public PlayerAudioController audioController; // Reference to the PlayerAudioController script
    bool canWinLevel = false; // Flag to indicate if the player can win the level

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player collided with enemy! So it loses");
            SceneManager.LoadScene("GameOver"); // Load the Game Over scene
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Item"))
        {
            Debug.Log("Player collected the item!");
            Destroy(collision.gameObject); // Destroy the item after collection
            itemImage.color = Color.white; // Change the image color to white to indicate collection
            canWinLevel = true; // Set the flag to true to allow winning the level
            audioController.PlayGetItem(); // Play the item collection sound
        }

        if (collision.CompareTag("FinalPoint")) 
        {
            if (canWinLevel) {
                Debug.Log("Player reached the final point! Level completed!");
                // Add logic to win the level, e.g., load next scene or show win UI
                SceneManager.LoadScene(nextLevelName);
            } else {
                Debug.Log("Player reached the final point but needs to collect the item first!");
            }
        }
    }
}

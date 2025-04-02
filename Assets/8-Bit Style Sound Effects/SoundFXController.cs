using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    AudioSource audioSource; // AudioSource component for playing sounds
    public AudioClip enemyDeathSound; // Sound to play when an enemy dies
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    public void PlayEnemyDeath() {
        audioSource.PlayOneShot(enemyDeathSound); // Play the enemy death sound
    }
}

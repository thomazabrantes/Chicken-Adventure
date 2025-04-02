using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource audioSource; // AudioSource component for playing sounds
    public AudioClip getItemSound; // Sound to play when collecting an item

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    public void PlayGetItem() {
        audioSource.PlayOneShot(getItemSound); // Play the item collection sound
    }
}

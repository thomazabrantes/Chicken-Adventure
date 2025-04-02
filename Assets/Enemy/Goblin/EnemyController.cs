using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f; // Speed of the enemy
    public Transform[] destinations; // Array of destination points

    int currentIndex = 0; // Current destination index

    Animator animator; // Animator component for animations
    SpriteRenderer sprite; // SpriteRenderer component for flipping the sprite

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component
        sprite = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
    }

    // Update is called once per frame
    void Update()
    {
        if(destinations.Length == 0) {
            animator.SetBool("b_isWalking", false); // If no destinations, stop walking animation
            return; // If no destinations, exit
        }

        animator.SetBool("b_isWalking", true); // Set walking animation

        var currentDestination = destinations[currentIndex]; // Get the current destination

        sprite.flipX = transform.position.x > currentDestination.position.x; // Flip the sprite based on direction

        transform.position = Vector3.MoveTowards(
            transform.position,
            currentDestination.position, // Move towards the current destination
            speed * Time.deltaTime // Speed of movement
        );

        if(Vector3.Distance(transform.position, currentDestination.position) <= 0.2f) {
            currentIndex = (currentIndex + 1) % destinations.Length; // Move to the next destination
        }
    }
}

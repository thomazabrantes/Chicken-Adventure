using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace to manage scenes

public class SceneController : MonoBehaviour
{
    // Update is called once per frame

    public String goToScene = "HomeScene"; // The name of the scene to load

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            //Debug.Log("Space key pressed!"); // Log to console when space is pressed
            SceneManager.LoadScene(goToScene); // Load the specified scene
        }
    }
}

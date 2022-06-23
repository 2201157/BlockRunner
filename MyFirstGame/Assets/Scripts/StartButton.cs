using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //Method called by the StartButton 
    public void StartGame()
    {
        //Loads the next scene to start the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

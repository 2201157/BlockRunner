using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float restartDelayTime = 2f;
    public GameObject completeLevelPanel;
    public TextMeshProUGUI gameOverLabel;


    //This method ends the game and its trigger either for falling or collidin with an obstacle
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = !gameHasEnded;
            Invoke("Restart", restartDelayTime);
        }
       
    }

    //This method is called when the Player passes through the endLine
    public void CompleteLevel()
    {
        //Makes the levelCompleted panel visible
        completeLevelPanel.SetActive(true);
    }

    //Restarts the game loading the actual scene
    public void Restart()
    {
        gameOverLabel.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    
}

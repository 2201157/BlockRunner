using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseEvent : MonoBehaviour
{
    public GameObject pauseLabel;
    private bool isGamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseLabel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;
            PauseGame();
            
        }
        
    }

    //This method pauses the game
    private void PauseGame()
    {
        if (isGamePaused)
        {
            Time.timeScale = 0f;
            pauseLabel.SetActive(true);
        }
        else
        {
            pauseLabel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}

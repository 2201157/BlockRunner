using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewLevel : MonoBehaviour
{
    //This method is triggered in the completedLevel Animation 
   public void LoadNextLevel()
    {
        //Instead of using a variable to access the "Restart" method from "Manager" Class
        //we can use the "FindObjectOfType" method
        FindObjectOfType<Manager>().Restart();
    }
}

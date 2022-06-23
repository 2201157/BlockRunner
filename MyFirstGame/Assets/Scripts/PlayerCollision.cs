using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private string OBSTACLE_TAG = "Obstacles";
    public PlayerMoviment playerMovement;
    public TextMeshProUGUI gameOverLabel;

    //Called everytime that the parent(Player) colides with something
    private void OnCollisionEnter(Collision collision)
    {
        //If the player collides with an obstacle then disable the movimente script and call the EndGame method
       if(collision.collider.tag == OBSTACLE_TAG)
        {
            GetComponent<Animator>().Play("FallDown");
            playerMovement.enabled = false;
            gameOverLabel.enabled = true;
            FindObjectOfType<Manager>().EndGame();
            
        } 
            

    }


}

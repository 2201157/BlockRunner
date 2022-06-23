using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    private string PLAYER_TAG = "Player";
    public Manager manager;

    //This method is called when the player passes through the endLine, it's similar to the "onCollisionEnter" but it doesnt actual collide
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == PLAYER_TAG)manager.CompleteLevel();
    }
}

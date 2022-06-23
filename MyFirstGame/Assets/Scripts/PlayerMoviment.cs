using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    //Player RigidBody
    public Rigidbody rigidBody;

    public float fowardSpeed = 10;
    public float sideSpeed = 10;
    private float fallLine = -1f;

    //it is called every fixed frame-rate frame 
    private void FixedUpdate()
    {
        //Makes the player move foward
        transform.Translate(Vector3.forward * Time.deltaTime * fowardSpeed, Space.World);

        //If "D" key is pressed
        if (Input.GetKey("d") && (transform.position.x < LevelBoundary.rightSide))
        {
            //Makes the player slide to the right
            transform.Translate(Vector3.right * Time.deltaTime * sideSpeed, Space.World);
        }

        //If "A" key is pressed
        if (Input.GetKey("a") && (transform.position.x > LevelBoundary.leftSide))
        {

            //Makes the player slide to the left
            transform.Translate(Vector3.left * Time.deltaTime * sideSpeed, Space.World);

        }

        //If the player falls bellow the ground, then execute the EndGame method
        if (rigidBody.position.y < fallLine) FindObjectOfType<Manager>().EndGame();
    }


}   

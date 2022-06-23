using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    //Player RigidBody
    public Rigidbody rigidBody;

    public float fowardForce = 3;
    public float sideForce = 100f;
    private float fallLine = -1f;

    //it is called every fixed frame-rate frame 
    private void FixedUpdate()
    {
        //Makes the player move foward
        //rigidBody.AddForce(0,0, fowardForce * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * fowardForce, Space.World);

        //If "D" key is pressed
        if (Input.GetKey("d"))
        {
            //Makes the player slide to the right
            rigidBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //If "A" key is pressed
        if (Input.GetKey("a")){

            //Makes the player slide to the left
            rigidBody.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        //If the player falls bellow the ground, then execute the EndGame method
        if (rigidBody.position.y < fallLine) FindObjectOfType<Manager>().EndGame();
    }


}   

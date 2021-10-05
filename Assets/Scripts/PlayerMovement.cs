using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 playerVelocity;
    private float playerSpeed = 3.0f;
    private float gravityValue = -3.0f;

    // Update is called once per frame
    void Update()
    {

        //This is for moving the character
        Vector3 move = new Vector3(Input.GetAxis("Vertical") * -1, 0, Input.GetAxis("Horizontal") ); //(* -1) to invert
        controller.Move(move * Time.deltaTime * playerSpeed); //multiply move vector by time and speed

        // This turns the player to face the direction they are moving in if not zero
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        playerVelocity.y += gravityValue * Time.deltaTime; //adds the gravity(y) value
        controller.Move(playerVelocity * Time.deltaTime);  //applies gravity
    }

}

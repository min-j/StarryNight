using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    CharacterController characterController;

    public float speed;
    public float jumpSpeed;
    public float gravity = 20f;

    private Vector3 moveDirection = Vector3.zero;
 
	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime); 
	}
}

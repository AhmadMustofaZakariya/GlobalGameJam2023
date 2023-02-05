using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2DBrackey controller;

	public float runSpeed = 40f;
	public Animator animator;
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("SPEED", Mathf.Abs(horizontalMove));
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("JUMPING", true);
		}
	}
	public void onLanding()
    {
		animator.SetBool("JUMPING", false);
    }

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}

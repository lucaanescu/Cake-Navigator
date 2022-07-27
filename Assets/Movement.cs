using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody rb;
	private float speed = 12;
	private Vector3 input;

	public bool flipped = false;

	void FixedUpdate()
	{
		GatherInput();
		Look();
		Move();
	}

	void GatherInput()
	{
		if (flipped == true)
		{
			input = new Vector3(-Input.GetAxisRaw("Horizontal"),0,-Input.GetAxisRaw("Vertical")).normalized;
		}
		else
		{
			input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
		}
		//input = new Vector3(Input.GetAxisRaw("Vertical"),0,Input.GetAxisRaw("Horizontal")).normalized;
	}

	void Look()
	{
		if (input != Vector3.zero){

			var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0));

			var skewedInput = matrix.MultiplyPoint3x4(input);

			var relative = (transform.position + skewedInput) - transform.position;
			var rot = Quaternion.LookRotation(relative, Vector3.up);

			transform.rotation = rot;
		}
	}

	void Move(){
		rb.MovePosition(transform.position + (transform.forward * input.magnitude).normalized * speed * Time.deltaTime);
	}
}

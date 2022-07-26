using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody rb;
	private float speed = 12;
	private Vector3 input;

	void Update()
	{
		GatherInput();
		Look();
	}

	void FixedUpdate()
	{
		Move();
	}

	void GatherInput()
	{
		input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
	}

	void Look()
	{
		if (input != Vector3.zero){
			var relative = (transform.position + input) - transform.position;
			var rot = Quaternion.LookRotation(relative, Vector3.up);

			transform.rotation = rot;
		}
	}

	void Move(){
		rb.MovePosition(transform.position + (transform.forward * input.magnitude) * speed * Time.deltaTime);
	}
}

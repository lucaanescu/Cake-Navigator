using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody rb;
	private Vector3 input;

	private float speed = 6f;

	void Update()
	{
		GatherInput();
		LookInDirection();
	}

	void FixedUpdate(){
		Move();
	}

	void GatherInput(){
		input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
	}

	void LookInDirection(){
		if(input != Vector3.zero)
		{

		
			var relative = (transform.position + input) - transform.position;
			var rot = Quaternion.LookRotation(relative,Vector3.up);

			transform.rotation = rot;
		}
	}

	void Move(){

		rb.MovePosition(transform.position + (transform.forward * input.magnitude) * speed * Time.deltaTime);
	}

}

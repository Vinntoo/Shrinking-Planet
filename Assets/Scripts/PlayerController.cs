using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10f;

	private float rotation;
	private Rigidbody rb;

	

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update ()
	{
		//rotation = Input.GetAxisRaw("Horizontal");

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{

			float xDelta = Input.GetTouch(0).deltaPosition.x;
			transform.Rotate(0f, -xDelta * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);

			//transform.Rotate(0, -xDelta * rotationSpeed * Time.deltaTime, 0);
		}


	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
		Quaternion deltaRotation = Quaternion.Euler(yRotation);
		Quaternion targetRotation = rb.rotation * deltaRotation;
		rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
		//transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour {
	public float moveSpeed = 5.0f;
	public float drag = 0.5f;
	public VirtualJoystick joystick;
	public float terminalRotationSpeed = 25.0f;
	public Vector3 MoveVector{ set; get;}

	private Rigidbody thisRigidbody;

	// Use this for initialization
	private void Start () {
		thisRigidbody = gameObject.AddComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void Update () {
		//MoveVector = PoolInput ();
		move ();
	}

	private void move()
	{
		thisRigidbody.AddForce ((MoveVector * moveSpeed)); 
	}

/*	private Vector3 PoolInput()
	{
		Vector3 dir = Vector3.zero;

		dir.x = joystick.Horizontal ();

		if (dir.magnitude > 1) {
			dir.Normalize ();

			return dir;
		}*/
	}


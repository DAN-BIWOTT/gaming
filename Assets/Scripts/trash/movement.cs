using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public VirtualJoystick joystick;
	public float speed=4f;

	public GameObject cube1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OrbitAround ();
	}

	void OrbitAround(){
		transform.RotateAround (cube1.transform.position, Vector3.up, speed * Time.deltaTime);
	}

}

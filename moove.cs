using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moove : MonoBehaviour {

	public float speed;
	public Transform planet;
	private RaycastHit hit;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Z))
			transform.RotateAround(planet.transform.position, Vector3.forward, speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.S))
			transform.RotateAround(planet.transform.position, Vector3.back, speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.Q))
			transform.RotateAround(planet.transform.position, Vector3.left, speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.D))
			transform.RotateAround(planet.transform.position, Vector3.right, speed * Time.deltaTime);
	}
}
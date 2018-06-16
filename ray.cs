using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour {

	// Use this for initialization
	private RaycastHit hit;
	private float index = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int layerMask = 1 << 8;
		layerMask = ~layerMask;
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask)) {
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
			Debug.Log("Did it");
			if (hit.distance < 5) {
				if (Input.GetKey(KeyCode.E))
					index++;
				if (index >= 50) {
					Destroy(hit.transform.gameObject);
					index = 0;
				}
			}
		}
		else {
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
			Debug.Log("Did not Hit");
		}
	}
}
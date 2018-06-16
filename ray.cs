using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour {

	// Use this for initialization
	private RaycastHit hit;
	private float index = 0;
	public float dechet = 0;
	public float tree = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int layerMask = 1 << 8;
		layerMask = ~layerMask;
		if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask)) {
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
			Debug.Log("Did it");
			if (hit.distance < 6) {
				if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.CompareTag("Collectable")) {
					index++;
				if (index >= 50) {
					Destroy(hit.transform.gameObject);
					index = 0;
					dechet = dechet + 3;
				}
			}
			if (Input.GetKey(KeyCode.E) && hit.transform.gameObject.gameObject.CompareTag("Recycler"))
				index++;
				while (dechet != 0 && index >= 50) {
					dechet = dechet - 3;
					tree++;
				}
			}
		}
		else {
			Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
			Debug.Log("Did not Hit");
		}
	}
}
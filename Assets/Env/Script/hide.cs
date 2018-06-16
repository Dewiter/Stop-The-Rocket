using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour {

	public Material		surface;
	private float		alphaHide = 0;
	private Color		tmp;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			tmp = surface.color;
			tmp.a -= 50;
			surface.color = tmp;

		}
		if (Input.GetKeyUp(KeyCode.Tab))
		{
			tmp = surface.color;
			tmp.a += 50;
			surface.color = tmp;

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consume : MonoBehaviour {

	private Renderer rend;
	private float offset = -1f;
	private float counter;
	void	Start()
	{
		rend = GetComponent<Renderer>();
		rend.material.shader = Shader.Find("graphs/Shader_diss");
	}
	// Update is called once per frame
	void Update ()
	{
		counter += Time.deltaTime;
		if (counter >= 5f)
		{
			if (offset <= 1f)
				offset += .5f;	
			counter = 0;
		}
		rend.material.SetFloat("Vector1_210D543D", offset);
	}
}

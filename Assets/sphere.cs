using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour 
{
	TextMesh label;
	void Start()
	{
		label = GetComponent<TextMesh>();
		print (label.text);
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Sphere") {
			label.text = "Finish";
			print (label.text);
		}

	}
}
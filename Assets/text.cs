using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour 
{
	TextMesh label;
	void Start()
	{
		label = GetComponent<TextMesh>();
		print (label.text);
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Tuningcar1") {
			label.text = "Finish";
			print (label.text);
		}

	}
}
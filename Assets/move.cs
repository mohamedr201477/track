using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public WheelCollider rf;
	public WheelCollider lf;
	public WheelCollider rb;
	public WheelCollider lb;
	public int speed;
	public int angle;


	void Update(){
		rb.motorTorque = Input.GetAxis("Vertical")* speed ;
		lb.motorTorque = Input.GetAxis("Vertical")* speed ;
		rf.steerAngle = Input.GetAxis ("Horizontal")* angle ;
		lf.steerAngle = Input.GetAxis ("Horizontal")* angle ;

	}

	
}

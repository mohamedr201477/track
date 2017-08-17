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
	public int brakeForce;


	void Update(){
		rb.motorTorque = Input.GetAxis("Vertical")* speed ;
		lb.motorTorque = Input.GetAxis("Vertical")* speed ;
		rf.steerAngle = Input.GetAxis ("Horizontal")* angle ;
		lf.steerAngle = Input.GetAxis ("Horizontal")* angle ;

		rb.brakeTorque = Input.GetAxis ("Jump") * brakeForce;
		lb.brakeTorque = Input.GetAxis ("Jump") * brakeForce;
		rf.brakeTorque = Input.GetAxis ("Jump") * brakeForce;
		lf.brakeTorque = Input.GetAxis ("Jump") * brakeForce;

	}


	
}

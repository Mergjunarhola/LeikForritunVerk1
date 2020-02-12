using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {

	public Rigidbody rb;
	public float Hradi =550;
	public float HlidarHradi =600;
	// Use this for initialization
	private Vector3 Noter;
	void Start () {
		Debug.Log("Hello");
		
	}
	
	// Update is called once per frame
	private void FixedUpdate() {
		rb.AddForce(0,0,Hradi*Time.fixedDeltaTime);
		Noter=rb.velocity;
		Noter.x=0;

		if (Input.GetKey("d")) {
			rb.AddForce(HlidarHradi*Time.fixedDeltaTime,0,0,ForceMode.VelocityChange);}
		else if (Input.GetKey("a")) {
			rb.AddForce(-HlidarHradi*Time.fixedDeltaTime,0,0,ForceMode.VelocityChange);}
		/*else {
			rb.velocity=Noter;
		}*/

	} 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camra_Follow : MonoBehaviour {

	public Transform player;
	public Vector3 Offset;
	
	// Update is called once per frame
	private void FixedUpdate() {
		transform.position=player.position +Offset;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collider : MonoBehaviour {
	public controls mov;
	void OnCollisionEnter(Collision CollisionInfo) {
		if (CollisionInfo.collider.tag == "Obstacle")
		{
			mov.enabled=false;
		}
	}
}


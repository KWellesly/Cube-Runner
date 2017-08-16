using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Movement moveScript;

	void OnCollisionEnter(Collision collideObject) {
		if (collideObject.collider.tag == "Obstacles") {
			moveScript.enabled = false;
			FindObjectOfType<EndGame> ().GameOver ();
		}

	}
}

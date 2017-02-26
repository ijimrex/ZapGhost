using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	private float speed;
	// Use this for initialization
	void Start () {
		speed = 40;
		GetComponent<Rigidbody> ().velocity = transform.forward * speed;
	}
}

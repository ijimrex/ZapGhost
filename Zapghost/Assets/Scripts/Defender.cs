using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 0.5f;
	public bool placed = false;
	private float nextFire;
	private bool startFire = false;
	private Rigidbody rigid;

	void Awake() {
		rigid = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > nextFire && startFire) {
			nextFire = Time.time + 1.0f/fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		} 
	}

	public void StartFire() {
		startFire = true;
	}

	public void Place() {
		placed = true;
	}

}

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
        if (Time.time > nextFire) {
			nextFire = Time.time + 1.0f/fireRate;
            Debug.Log("Create shot");

			Instantiate (shot, shotSpawn.position, Quaternion.Euler(shotSpawn.rotation.x, shotSpawn.rotation.y, shotSpawn.rotation.z));
		} 
	}

	public void StartFire() {
		startFire = true;
	}

	public void Place() {
		placed = true;
	}

}

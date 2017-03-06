using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 0.5f;
	public int type = 0;
	public bool placed = false;
	private float nextFire;
	private bool startFire = false;

	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > nextFire && startFire) {
			nextFire = Time.time + 1.0f/fireRate;
			GameObject bolt = Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			if (type == 1) {
				bolt.transform.Rotate (new Vector3(0, 0,-90));
			} else {
				bolt.transform.Rotate (new Vector3(0, 90,-90));
			}

		} 
	}

	public void StartFire() {
		startFire = true;
	}

	public void Place() {
		placed = true;
	}

}

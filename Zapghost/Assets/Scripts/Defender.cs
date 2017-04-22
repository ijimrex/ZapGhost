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
	private bool startFire = true;

	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log ("准备！！！！！");
		Debug.Log (Time.time );
		Debug.Log (nextFire);
		if (Time.time > nextFire && startFire) {
			nextFire = Time.time + 1.0f/fireRate;
			GameObject bolt = Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			if (type == 1) {
				Debug.Log ("开炮！！！！！");
				bolt.transform.Rotate (new Vector3 (0, 0, -90));
			} else if (type == 0) {
				bolt.transform.Rotate (new Vector3 (0, 90, -90));
			} else {
				bolt.transform.Rotate (new Vector3 (0, -90, -90));
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

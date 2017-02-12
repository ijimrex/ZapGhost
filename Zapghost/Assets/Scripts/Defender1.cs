using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender1 : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;
	// Use this for initialization
	void Start () {
		fireRate = 5;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		} 
	}
}

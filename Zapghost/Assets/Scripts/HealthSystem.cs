using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

	public int startHealth = 100;
	public Text healthText;
	public int currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = startHealth;
		healthText.text = "Health: " + currentHealth.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + currentHealth.ToString ();
	}
}

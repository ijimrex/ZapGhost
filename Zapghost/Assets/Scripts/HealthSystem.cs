using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour {
	
	public int level = 1;
	public int startHealth = 100;
	public Text healthText;
	public int currentHealth;
	// Use this for initialization
	void Start () {
		currentHealth = startHealth;
		healthText.text = currentHealth.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = currentHealth.ToString ();
		if (currentHealth <= 0) {
			SceneManager.LoadScene("LostGame");
		}
	}
}

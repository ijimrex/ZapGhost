using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {
	
	private HealthSystem healthSystem;
	private MonsterHealth monsterHealth;

	void Start() {
		healthSystem = GameObject.Find ("Health").GetComponent<HealthSystem> ();
	}

	void OnTriggerExit(Collider other)
	{
		monsterHealth = other.gameObject.GetComponent<MonsterHealth> ();
		if (other.tag != "Defender") {
			Destroy(other.gameObject);
		}
		if (other.tag == "Monster") {
			GameObject.Find ("GameController").GetComponent<GameController> ().deadMonsterNum ++;
			healthSystem.currentHealth -= monsterHealth.power;
		}
	}
}

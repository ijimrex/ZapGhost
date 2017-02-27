using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {
	private MoneySystem moneySystem;
	private MonsterHealth monsterHealth;
	void Start() {
		moneySystem = GameObject.Find ("Money").GetComponent<MoneySystem> ();
	}

	void OnTriggerExit(Collider other)
	{
		monsterHealth = other.gameObject.GetComponent<MonsterHealth> ();
		if (other.tag != "Defender") {
			Destroy(other.gameObject);

		}
		if (other.tag == "Monster") {
			moneySystem.blood -= monsterHealth.power;
		}
	}
}

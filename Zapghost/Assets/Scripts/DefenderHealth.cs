using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderHealth : MonoBehaviour {

	public int startingHealth = 200;
	private int currentHealth;
	private int takeDamage; // the damage caused by per bolt
	Defender defScript;
	private MoneySystem money;
	private MonsterHealth otherAttack; //the attack of the monster which attack the defender 
	bool isDead;

	void Awake() {
		defScript = GetComponent<Defender> ();
	}

	void Start ()
	{
		currentHealth = startingHealth;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Monster" && currentHealth >0)
		{
			TakeDamage (takeDamage);
		}
	}

	void OnTriggerStay(Collider other) 
	{
		if (other.tag == "Monster" && currentHealth >0)
		{
			otherAttack = other.gameObject.GetComponent<MonsterHealth>();
			takeDamage = otherAttack.power;
			TakeDamage (takeDamage);
		}
	}

	public void TakeDamage (int amount)
	{
		if (!defScript.placed)
			return;
		
		if (isDead) {
			return;
		}

		currentHealth -= amount;
		if(currentHealth <= 0)
		{
			Death ();
		}
	}


	void Death ()
	{   
		isDead = true;
		Destroy (gameObject);
	}

}
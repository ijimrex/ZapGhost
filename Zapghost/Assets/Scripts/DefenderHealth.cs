using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderHealth : MonoBehaviour {

	public int startingHealth = 200;
	public int currentHealth;
	public int cost = 10; // the score you will get when the Monster dead
	public int takeDamage = 20; // the damage caused by per bolt
	private MoneySystem money;

	bool isDead;

	void Awake ()
	{
		currentHealth = startingHealth;

	}

	// Use this for initialization
	void Start () {
		money = GameObject.Find("Money").GetComponent<MoneySystem> ();
		money.currentMoney -= cost;
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
			TakeDamage (takeDamage);
		}
	}

	public void TakeDamage (int amount)
	{
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
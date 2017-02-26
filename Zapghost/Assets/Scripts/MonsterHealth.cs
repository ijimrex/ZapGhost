﻿using UnityEngine;

public class MonsterHealth : MonoBehaviour
{
	public int startingHealth = 3000;
	public int currentHealth;
	public int scoreValue = 10; // the score you will get when the Monster dead

	public bool isDead;
	private MoneySystem moneyManager;
//	public GameObject money;
//	MoneySystem Money;

	void Awake ()
	{

		currentHealth = startingHealth;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Bolt" && currentHealth >0)
		{
			TakeDamage (20);
			Destroy (other.gameObject);
		}
	}




	public void TakeDamage (int amount)
	{
		if(isDead)
			return;

		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;
		addMoney ();

		Destroy (gameObject);

	}
	void addMoney(){
		moneyManager = GameObject.Find ("Money").GetComponent<MoneySystem> ();
		moneyManager.currentMoney += scoreValue;
//		MoneySystem moneyvarable = (MoneySystem) money.GetComponent( typeof(MoneySystem) );
//		moneyvarable.currentMoney += scoreValue;
//		moneyvarable.moneyText.text = "Money: " + moneyvarable.currentMoney.ToString ();
		
	} 

}


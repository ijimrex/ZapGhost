using UnityEngine;

public class MonsterHealth : MonoBehaviour
{
	public int startingHealth = 500;
	public int currentHealth;
	public int scoreValue = 10; // the score you will get when the Monster dead

	bool isDead;

	void Awake ()
	{

		currentHealth = startingHealth;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Bolt" && currentHealth >0)
		{
			TakeDamage (1);
		}
	}
	void OnTriggerStay(Collider other) 
	{
		if (other.tag == "Bolt" && currentHealth >0)
		{
			TakeDamage (1);
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
		Destroy (gameObject);


	}

}


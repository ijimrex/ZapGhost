using UnityEngine;

public class MonsterHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int currentHealth;
	public int scoreValue = 10; // the score you will get when the Monster dead

	CapsuleCollider capsuleCollider;
	bool isDead;

	void Awake ()
	{
		capsuleCollider = GetComponent <CapsuleCollider> ();

		currentHealth = startingHealth;
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

		capsuleCollider.isTrigger = true;


	}

}


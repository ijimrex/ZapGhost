using UnityEngine;

public class MonsterHealth : MonoBehaviour
{

	public int startingHealth = 100;
	private int currentHealth;
	public int coin = 10; // the score you will get when the Monster dead
	public int power = 20; // attack power
	private int takeDamage; // damage caused by defender

	private BoltPower otherAttack; // store the bolt which attack monster


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
			otherAttack = other.gameObject.GetComponent<BoltPower>();
			takeDamage = otherAttack.power;
			TakeDamage (takeDamage);
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

		moneyManager.currentMoney += coin;

	} 

}


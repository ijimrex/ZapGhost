using UnityEngine;

public class MonsterHealth : MonoBehaviour
{
	public int startingHealth = 100;
	private int currentHealth;
	public int coin = 10; // the score you will get when the Monster dead
	public int power = 20; // attack power
	private int takeDamage; // damage caused by defender
	private int damageType;

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
			damageType = otherAttack.type;
			TakeDamage (takeDamage, damageType);
			Destroy (other.gameObject);
		}
		if (other.tag == "sword" && currentHealth >0)
		{
			Debug.Log ("sword damage");
			takeDamage = other.gameObject.GetComponent<ShortAttackPower>().power;
			TakeDamage (takeDamage, 0);
			Destroy (other.gameObject);
		}
	}




	public void TakeDamage (int amount, int type)
	{
		if(isDead)
			return;

		currentHealth -= amount;

		if(currentHealth <= 0)
		{
			Death ();
		}

		//if attack type is frozen
		if (type == 1) {
			MonsterMovement move = GetComponent<MonsterMovement> ();
			move.frozenTime = Time.time + 1f;
		}

	}


	void Death ()
	{
		isDead = true;
		addMoney ();
		GameObject.Find ("GameController").GetComponent<GameController> ().deadMonsterNum ++;

		Destroy (gameObject);

	}
	void addMoney(){
		moneyManager = GameObject.Find ("Money").GetComponent<MoneySystem> ();
		moneyManager.currentMoney += coin;
	} 

}


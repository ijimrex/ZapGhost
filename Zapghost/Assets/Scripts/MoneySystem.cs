using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour {
	public int currentMoney;
	public int startMoney = 100;
	public Text moneyText;
//	public GameObject monster;

//	bool dead=monster.GetComponent<MonsterHealth>();
//	GameObject.Find("Monster").GetComponent<MonsterHealth>().isDead;
	// Use this for initialization
	void Awake(){
		currentMoney = startMoney;
		moneyText.text = "Money: " + currentMoney.ToString ();

	}
	void Start () {
//		MonsterHealth dead = (MonsterHealth) monster.GetComponent( typeof(MonsterHealth) ) ;
		currentMoney = startMoney;
		
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text = "Money: " + currentMoney.ToString ();
//		MonsterHealth dead = (MonsterHealth) monster.GetComponent( typeof(MonsterHealth) ) ;
////		if (dead.isDead)
////			addMoney ();
//
//		moneyText.text = "Money: " + dead.currentHealth.ToString();
		
	}

//	void addMoney(){
//		currentMoney += 20;
//		moneyText.text = "Money: " + currentMoney.ToString ();
//		
//		
//	}
//	void decreaseMoney(){
//		currentMoney-= 20;
//		moneyText.text = "Money: " + currentMoney.ToString ();
//	
//	}
}

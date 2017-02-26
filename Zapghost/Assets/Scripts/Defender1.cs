using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender1 : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
//	public GameObject money;
	private MoneySystem moneyManager;
	private float nextFire;
	private int decrease = 10;
	private bool startFire = false;
	// Use this for initialization
	void Awake(){
		
	}
	void Start () {
		decreaseMoney();
		fireRate = 0.5f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time > nextFire && startFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		} 
	}
	void decreaseMoney(){
//		MoneySystem moneyvarable = (MoneySystem) money.GetComponent( typeof(MoneySystem) );
//		moneyvarable.currentMoney -= decrease;
//		moneyvarable.moneyText.text = "Money:" + moneyvarable.currentMoney.ToString ();
		moneyManager = GameObject.Find ("Money").GetComponent<MoneySystem> ();
		moneyManager.currentMoney -= decrease;

	} 

	public void StartFire() {
		startFire = true;
	}
}

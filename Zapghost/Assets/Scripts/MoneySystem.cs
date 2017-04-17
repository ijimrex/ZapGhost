using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour {
	public int currentMoney;
	public int startMoney = 100;
	public Text moneyText;

	// Use this for initialization
	void Start () {
		currentMoney = startMoney;
		moneyText.text = currentMoney.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text = currentMoney.ToString ();
	}

}

using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;


	void Update ()
	{
		transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log (other.name );
	}


}
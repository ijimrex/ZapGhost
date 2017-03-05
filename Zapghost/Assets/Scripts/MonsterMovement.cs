using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
	public float moveSpeed = 5f;


	void Update ()
	{
		transform.Translate(new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime);
	}
}
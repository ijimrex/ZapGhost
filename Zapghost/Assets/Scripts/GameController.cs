using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public int monsterNum;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	private int GetRandom(int[] arr){
		int n = Random.Range(0, arr.Length - 1);

		return arr[n];
	}
	int[] Location = { -40, -20, 0, 20, 40 };


	void Start ()
	{
		StartCoroutine(SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{    
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < monsterNum; i++) {
			Debug.Log(GetRandom(Location));
			Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnWait);
		}
		yield return new WaitForSeconds (waveWait);

	}
}  
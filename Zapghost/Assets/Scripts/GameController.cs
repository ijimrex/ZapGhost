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


	void Start ()
	{
		StartCoroutine(SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{    
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < monsterNum; i++) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnWait);
		}
		yield return new WaitForSeconds (waveWait);

	}
}  
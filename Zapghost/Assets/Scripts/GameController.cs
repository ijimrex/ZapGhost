using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public GameObject Monster;
	public GameObject Monster1;
	public GameObject Monster2;
	public GameObject Monster3;
	public Vector3 spawnValues;
	public int monsterNum;
	public int monster1Num;
	public int monster2Num;
	public int monster3Num;

	private int len; // the max number of monster
	public int deadMonsterNum = 0; 
	public float spawnWait;
	public float startWait;
	public float waveWait;

	private int GetRandom(int[] arr){
		int n = Random.Range(0, arr.Length - 1);

		return arr[n];
	}
	int[] Location = { -40, -20, 0, 20, 40, 60 };


	void Start ()
	{   
		int[] arr = { monsterNum, monster1Num, monster2Num, monster3Num };
		System.Array.Sort (arr);
		len = arr[arr.Length - 1];
		StartCoroutine(SpawnWaves ());
	}

	void Update() {
		if (deadMonsterNum == len) {
			SceneManager.LoadScene("WinGame");
		}
	}
	IEnumerator SpawnWaves ()
	{    
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < len; i++) {
			
			//monster
			if (i < monsterNum) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Monster, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (0.5f);
			}


			//monster1
			if (i < monster1Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Monster1, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (0.5f);
			}


			//monster2
			if (i < monster2Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Monster2, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (0.5f);
			}


			//monster3
			if (i < monster3Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Monster3, spawnPosition, spawnRotation);
			}


			yield return new WaitForSeconds (spawnWait);
		}
		yield return new WaitForSeconds (waveWait);

	}
}  
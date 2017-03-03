using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public GameObject Monster;
	public GameObject Monster1;
	public GameObject Monster2;
	public GameObject Monster3;
	private Transform MonsterParent;
	public Vector3 spawnValues;
	public int monsterNum;
	public int monster1Num;
	public int monster2Num;
	public int monster3Num;
	private int totalNum;

	private int len; // the max number of monster
	public int deadMonsterNum = 0; 
	public float spawnWait;
	public float startWait;
	public float waveWait;

	private float GetRandom(float[] arr){
		int n = Random.Range(0, arr.Length - 1);

		return arr[n];
	}
	float[] Location = { -0.4f, -0.2f, 0, 0.2f, 0.4f, 0.6f };


	void Start ()
	{
<<<<<<< HEAD
        //Debug.Log("Start spawn waves" + monster1Num.ToString() + "," + monster2Num.ToString());
=======
		
        Debug.Log("Start spawn waves" + monster1Num.ToString() + "," + monster2Num.ToString());
>>>>>>> 66423844735d1312211e487627ae44e9e796a4dc
		int[] arr = { monsterNum, monster1Num, monster2Num, monster3Num };
		System.Array.Sort (arr);
		len = arr[arr.Length - 1];
		totalNum = monsterNum + monster1Num + monster2Num + monster3Num;
		GameObject temp = GameObject.Find ("All");
		MonsterParent = temp.transform;
        //cannot start coroutine for the second time
		StartCoroutine(SpawnWaves ());
	}

	void Update() {
		if (deadMonsterNum == totalNum) {
			SceneManager.LoadScene("WinGame");
		}
	}
	IEnumerator SpawnWaves ()
	{    
		yield return new WaitForSeconds (startWait);
		for (int i = 0; i < len; i++) {
            //Debug.Log("for loop" + i.ToString());
			//monster
			if (i < monsterNum) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				GameObject obj = Instantiate (Monster, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
				yield return new WaitForSeconds (0.5f);
			}


			//monster1
			if (i < monster1Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				GameObject obj = Instantiate (Monster, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
				yield return new WaitForSeconds (0.5f);
			}


			//monster2
			if (i < monster2Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				GameObject obj = Instantiate (Monster, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
				yield return new WaitForSeconds (0.5f);
			}


			//monster3
			if (i < monster3Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				GameObject obj = Instantiate (Monster, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
			}


			yield return new WaitForSeconds (spawnWait);
		}
		yield return new WaitForSeconds (waveWait);

	}
}  
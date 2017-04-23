using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public int level;
	private int totalLevel;
	public GameObject Monster;
	public GameObject Monster1;
	public GameObject Monster2;
	public GameObject Monster3;
	private Transform world;
	private Quaternion spawnRotation;
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
		int n = Random.Range(0, arr.Length);

		return arr[n];
	}
	float[] Location = new float[5];
	//int[] Location = { -40, -20, 0, 20, 40, 60 };
	void Awake () {
		Location [0] = GameObject.Find ("Grid0").transform.position.x;
		Location [1] = GameObject.Find ("Grid1").transform.position.x;
		Location [2] = GameObject.Find ("Grid2").transform.position.x;
		Location [3] = GameObject.Find ("Grid3").transform.position.x;
		Location [4] = GameObject.Find ("Grid4").transform.position.x;
		world = GameObject.Find ("All").transform;
		spawnRotation = world.localRotation;
		totalLevel = 4;
	}
		


	void Start ()
	{
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
			/*if (level < totalLevel) {
				SceneManager.LoadScene ("Level" + (level + 1));
			} else {
				SceneManager.LoadScene("WinGame");
			}*/

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
				GameObject obj = Instantiate (Monster, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
				yield return new WaitForSeconds (0.5f);
			}


			//monster1
			if (i < monster1Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				GameObject obj = Instantiate (Monster1, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
				yield return new WaitForSeconds (0.5f);
			}


			//monster2
			if (i < monster2Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				GameObject obj = Instantiate (Monster2, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
				yield return new WaitForSeconds (0.5f);
			}


			//monster3
			if (i < monster3Num) {
				Vector3 spawnPosition = new Vector3 (GetRandom(Location), spawnValues.y, spawnValues.z);
				GameObject obj = Instantiate (Monster3, spawnPosition, spawnRotation);
				obj.transform.SetParent (MonsterParent);
			}


			yield return new WaitForSeconds (spawnWait);
		}
		yield return new WaitForSeconds (waveWait);

	}
}  
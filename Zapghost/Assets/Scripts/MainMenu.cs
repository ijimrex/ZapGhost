using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject MenuPanel, AboutPanel;

	public void StartGame(int num) {
		string levelName = "Level" + num;
		SceneManager.LoadScene(levelName);
	}

	public void PlayAgain() {
		int currentLevel = GameObject.Find ("HealthSystem").GetComponent<HealthSystem>().level;
		Debug.Log(currentLevel);
		string levelName = "Level" + currentLevel;
		SceneManager.LoadScene(levelName);
	}

	public void NextLevel() {
		int nextLevel = GameObject.Find ("HealthSystem").GetComponent<HealthSystem>().level + 1;			
		string levelName = "Level" + nextLevel;
		SceneManager.LoadScene(levelName);
	}


    public void Quit()
    {
       Application.Quit();
    }

    public void About()
    {
        MenuPanel.SetActive(false);
        AboutPanel.SetActive(true);
        

    }

    public void returnMenu()
    {
        MenuPanel.SetActive(true);
        AboutPanel.SetActive(false);
    }
}

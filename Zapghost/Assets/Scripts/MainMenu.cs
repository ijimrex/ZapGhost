using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject MenuPanel, AboutPanel;

	public void StartGame(int num) {
		PlayerPrefs.SetInt("currentLevel", num);
		string levelName = "Level" + num;
		SceneManager.LoadScene(levelName);
	}

	public void PlayAgain() {  
		int currentLevel = PlayerPrefs.GetInt ("currentLevel");
		string levelName = "Level" + currentLevel;
		SceneManager.LoadScene(levelName);
	}

	public void NextLevel() {
		Debug.Log (PlayerPrefs.GetInt ("currentLevel"));
		int nextLevel = PlayerPrefs.GetInt ("currentLevel") + 1;
		PlayerPrefs.SetInt("currentLevel", nextLevel);
		string levelName = "Level" + nextLevel;
		SceneManager.LoadScene(levelName);
	}

	public void LevelSelect() {
		SceneManager.LoadScene("LevelSelect");
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

	public void mainMenu() {
		SceneManager.LoadScene ("StartGame");
	}
}

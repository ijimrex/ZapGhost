using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject Pausebutton, PausePanel;
	
    public void onPause()
    {
        PausePanel.SetActive(true);
        Pausebutton.SetActive(false);
        Time.timeScale = 0;

    }

    public void onUnPause()
    {
        PausePanel.SetActive(false);
        Pausebutton.SetActive(true);
        Time.timeScale = 1;

    }

    public void returnMenu()
    {
        SceneManager.LoadScene("StartGame");
        Time.timeScale = 1;
    }

}

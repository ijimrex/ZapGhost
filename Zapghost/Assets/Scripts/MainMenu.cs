using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject MenuPanel, AboutPanel;



    public void StartGame()
    {
        SceneManager.LoadScene("Level1");

    }

    //public void Quit()
    //{
    //    Application.Quit();
    //}

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

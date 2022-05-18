using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgmt : MonoBehaviour
{
    public GameObject creditsPanel;

    public void ChangeToGame() {
        SceneManager.LoadScene(1);
    }

    public void ReloadGame() {
        SceneManager.LoadScene(1);
    }

    public void ChangeToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void CreditsToggle(){
        if(creditsPanel.activeInHierarchy == false)
            creditsPanel.SetActive(true);
            else
            creditsPanel.SetActive(false);

    }
}

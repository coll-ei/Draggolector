using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject hadPanel;
    public void PlayGame(int scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void ButtonPlay()
    {
        if (hadPanel.activeInHierarchy)
        {
            hadPanel.SetActive(false);
            return;
        }
        if (!hadPanel.activeInHierarchy)
        {
            hadPanel.SetActive(true);
            return;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

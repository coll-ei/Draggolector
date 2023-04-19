using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject music;
    public GameObject menu;
    public void Music()
    {
        if(music.activeInHierarchy)
        {
            music.SetActive(false);
            return;
        } 
        if(!music.activeInHierarchy)
        {
            music.SetActive(true);
            return;
        }
    }
    public void Moven()
    {
        if (menu.activeInHierarchy)
        {
            Debug.Log("ez");
            menu.SetActive(false);
            Time.timeScale = 1;
            return;
        }
        if(!menu.activeInHierarchy)
        {
            Debug.Log("gg");
            menu.SetActive(true);
            Time.timeScale = 0;
            return;
        }
    }
    public void ExitToScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

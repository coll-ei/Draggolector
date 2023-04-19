using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Image healthbar;
    public float Damage;
    void Update()
    {
        Debug.Log("health : " + healthbar.fillAmount);
        if (GameObject.FindGameObjectsWithTag("Home").Length == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (healthbar.fillAmount == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void FixedUpdate()
    {
        
    }
}

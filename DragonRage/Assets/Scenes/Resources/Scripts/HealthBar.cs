using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image health;
    public float timer;
    public bool canMinus = true;
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(canMinus)
        {
            Debug.Log(health.fillAmount);
            StartCoroutine(Minus());
        }
        if (health.fillAmount == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    IEnumerator Minus()
    {
        canMinus = false;
        health.fillAmount -= 1 / timer;
        yield return new WaitForSeconds(1);
        canMinus = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    private GameObject fire;
    public float seconds;
    private void Start()
    {

        fire = gameObject.transform.GetChild(0).gameObject;
        fire.SetActive(false);
    }
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<DragonEgg>())
        {
            Destroy(collision.gameObject);
            StartCoroutine(flame());
        }
    }
    IEnumerator flame()
    {
        fire.SetActive(true);
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}

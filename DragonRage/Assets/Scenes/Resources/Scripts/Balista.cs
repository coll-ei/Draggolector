using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balista : MonoBehaviour
{
    private bool canAtack = true;
    public Image healthbar;
    public float timer;
    void Start()
    {
        
    }

    void Update()
    {
        if (canAtack)
        {
            StartCoroutine(atack());
        }
    }
    IEnumerator atack()
    {
        canAtack = false;
        healthbar.fillAmount -= 1 / timer / 10;
        yield return new WaitForSeconds(1);
        canAtack = true;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<DragonEgg>())
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}

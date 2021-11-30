using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitpoint : MonoBehaviour
{

    public static int Damge = 1;
    public int enemyHealth;
    private bool minus = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (enemyHealth == 1)
            Destroy(gameObject);
        else
            minus = true;

    }
    private void Update()
    {
        if(minus == true)
        {
            enemyHealth -= Damge;
            minus = false;
            if(enemyHealth == 4)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            else if (enemyHealth == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}

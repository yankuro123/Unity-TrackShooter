using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{

    public static int Damge = 1;
    public int enemyHealth;
    public static float speed;
    public static Rigidbody2D enemy;
    private bool minus = false;

    void Awake()
    {
        enemy = gameObject.GetComponent<Rigidbody2D>();    
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (enemyHealth == 1)
            Destroy(gameObject);
        else
            minus = true;

    }
}

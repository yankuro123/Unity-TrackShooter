using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{

    public static int DamgeGun;
    public static int DamgeCanon;
    public int enemyHealth;
    public static float speed;
    public static Rigidbody2D enemy;
    public int BaseMoney = 15;

    private bool minus = false;
    void Start()
    {
        enemy = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
            if(enemyHealth == 4)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
            }
            else if (enemyHealth == 2)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        if (Money.EnemyCounter == 10)
        {
            Money.Bonus += 5;
            Money.EnemyCounter = 0;
        }
        else
            return;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SmallCaliber")
        {
            enemyHealth -= DamgeGun;
            if (enemyHealth <= 0)
            {
                Money.EnemyCounter += 1;
                Destroy(gameObject);
                Money.MoneyCount += (BaseMoney + Money.Bonus);
            }
        }
        else if (collision.gameObject.tag == "LargeCaliber")
        {
            enemyHealth -= DamgeCanon;
            if (enemyHealth <= 0)
            {
                Money.EnemyCounter += 1;
                Destroy(gameObject);
                Money.MoneyCount += (BaseMoney + Money.Bonus);
            }
        }

    }
}

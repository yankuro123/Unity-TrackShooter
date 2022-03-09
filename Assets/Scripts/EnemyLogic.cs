using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{

    //public static int DamgeGun = 1;
    //public static int DamgeCanon = 6;
    //public float enemyHealth = 30;
    public float RemainHealth;
    public static float speed = 1.0f;
    public static Rigidbody2D enemy;
    public int BaseMoney = 15;
    public float test;
    public float test1;
    public float test2;

    private float ThresholdYellow;
    private float ThresholdRed; 
    //private bool minus = false;
    void Start()
    {
        enemy = gameObject.GetComponent<Rigidbody2D>();
        RemainHealth = StatManager.enemyHealth;
        ThresholdYellow = StatManager.enemyHealth * 0.5f;
        ThresholdRed = StatManager.enemyHealth * 0.2f;
    }
    private void Update()
    {
        test = RemainHealth;
        test1 = ThresholdYellow;
        test2 = ThresholdRed;
        if (RemainHealth <= ThresholdYellow)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        if (RemainHealth <= ThresholdRed)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (RemainHealth <= 0)
        {
            Money.EnemyCounter += 1;
            Destroy(gameObject);
            Money.MoneyCount += (BaseMoney + Money.Bonus);
        }
        if (Money.EnemyCounter == 10)
        {
            Money.Bonus += 5;
            Money.EnemyCounter = 0;
            StatManager.enemyHealth += StatManager.enemyHealth * 0.05f;
        }
        else
            return;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SmallCaliber")
        {
            RemainHealth -= StatManager.damge;
        }
        else if (collision.gameObject.tag == "LargeCaliber")
        {
            RemainHealth -= StatManager.Damge;
        }


    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

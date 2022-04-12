using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseLine : MonoBehaviour
{
    public static float health, MaxHealth;
    public BaseHealth healthBar;
    public static Rigidbody2D baseline;
    // Start is called before the first frame update
    void Start()
    {
        baseline = gameObject.GetComponent<Rigidbody2D>();
        MaxHealth = StatManager.BaseHealth;
        health = MaxHealth;
        Debug.Log("Health " + StatManager.BaseHealth);
        InvokeRepeating("Healing", 0.0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {     
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            if ((health-=10f) > 0)
                health -= 10f;
            else
                health = 0;
            healthBar.UpdateHealthBar();          
        }
        if (health == 0)
        {
            Debug.Log("Move to Losing Scene");
        }
        else
            return;
    }
    void Healing()
    {
        if (PauseAndShop.pause == false)
        {
            if (health < 100 && health > 0)
            {
                Debug.Log("Healing");
                health += StatManager.BaseRegen;
                healthBar.UpdateHealthBar();
            }
        }
        else
            return;
    }
}

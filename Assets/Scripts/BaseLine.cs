using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLine : MonoBehaviour
{
    public static float health, MaxHealth;
    public BaseHealth healthBar;
    public static Rigidbody2D baseline;
    // Start is called before the first frame update
    void Start()
    {
        baseline = gameObject.GetComponent<Rigidbody2D>();
        MaxHealth = 100f;
        health = MaxHealth;
        InvokeRepeating("Healing", 1.0f, 60.0f);
    }

    // Update is called once per frame
    void Update()
    {     
    }  
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        health -= 10f;
        healthBar.UpdateHealthBar();
    }
    void Healing()
    {
        if (health < 100)
        {
            Debug.Log("Healing");
            health += 10;
            healthBar.UpdateHealthBar();
        }
    }
}

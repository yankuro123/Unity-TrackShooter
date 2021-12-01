using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject Enemy;
    public float secondsBetweenSpawn;
    public float elapsedTime;
    public Transform Player;
    //public float seconds;
    Vector2 pointA = new Vector2(-10.95f, 6f);
    Vector2 pointB = new Vector2(10.95f, 6f);
    public static Vector2 direction;
    public static Vector2 MovementRetain;
    public float Timer;
    public float OffsetRate;

    private Transform Spawn;
    private float Offset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseAndShop.pause == false)
        {
            Time.timeScale = 1;
            EnemyLogic.speed = 0.2f;
            direction = Player.position - Spawn.position;
            float time = Time.time * 0.3f;
            secondsBetweenSpawn = Timer - Offset;
            transform.position = Vector2.Lerp(pointA, pointB, Mathf.PingPong(time, 1));
            elapsedTime += Time.deltaTime;
            if (elapsedTime > secondsBetweenSpawn)
            {
                Vector2 spawnPosition = new Vector2(Spawn.position.x, Spawn.position.y);
                GameObject newEnemy = (GameObject)Instantiate(Enemy, spawnPosition, Quaternion.identity) as GameObject;
                newEnemy.GetComponent<Rigidbody2D>().velocity = direction * EnemyLogic.speed;
                MovementRetain = direction;
                newEnemy.AddComponent<OutOfScreenDestroy>();
                newEnemy.AddComponent<EnemyLogic>();
                elapsedTime = 0;
                if (secondsBetweenSpawn >= 0.5f)
                {
                    Offset += OffsetRate;
                }

            }
        }
        else
        {
            Time.timeScale = 0;
            return;
        }
    }
}


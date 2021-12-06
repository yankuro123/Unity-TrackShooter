using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseAndShop : MonoBehaviour
{
    public Button Pause;
    public Button Shop;
    public static bool PauseLock;
    public static bool pause;
    public Canvas PauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Pause.GetComponent<Button>();
        Shop.GetComponent<Button>();
        Pause.onClick.AddListener(PauseGame);
        Shop.onClick.AddListener(MovetoShop);
        PauseCanvas.GetComponent<Canvas>();
        PauseCanvas.gameObject.SetActive(false);
        pause = false;
        PauseLock = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape) && PauseLock == false)
        {
            PauseGame();
        }*/
        if (Input.GetKeyDown(KeyCode.S))
        {
            MovetoShop();
        }
    }

    void PauseGame()
    {
        Debug.Log("Pause Clicked");
        /*EnemyLogic.speed = 0.0f;
        EnemyLogic.enemy.velocity = SpawnPoint.MovementRetain * EnemyLogic.speed;*/
        //Time.timeScale = 0;
        Cursor.visible = false;
        MountLogic.retainF = MountLogic.Mount.velocity.x;
        PauseLock = true;
        pause = true;
        PauseCanvas.gameObject.SetActive(true);
        Debug.Log("Paused");
    }

    void MovetoShop()
    {
        if (PauseLock == false)
        {
            MountLogic.retainF = MountLogic.Mount.velocity.x;
            PauseLock = true;
            pause = true;
        }
    }
}

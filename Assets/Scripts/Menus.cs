using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    public Button Continue;
    public Button Exit;
    public Canvas PauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Continue.GetComponent<Button>();
        Exit.GetComponent<Button>();
        PauseCanvas.GetComponent<Canvas>();
        Exit.onClick.AddListener(Application.Quit);
        Continue.onClick.AddListener(ContinuePlaying);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && PauseAndShop.PauseLock == true)
        {
            ContinuePlaying();
        }
    }
    void ContinuePlaying()
    {
        if(PauseAndShop.pause == true)
        {
            Cursor.visible = false;
            /*EnemyLogic.speed = 0.2f;
            EnemyLogic.enemy.velocity = SpawnPoint.MovementRetain * EnemyLogic.speed;*/
            MountLogic.Mount.velocity = new Vector2(1f, 0f) * MountLogic.retainF;
            PauseAndShop.pause = false;
            PauseAndShop.PauseLock = false;
            PauseCanvas.gameObject.SetActive(false);           
        }
    }
}

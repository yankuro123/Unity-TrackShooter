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
        
    }

    void PauseGame()
    {
        Debug.Log("Pause Clicked");
        if (PauseLock == false)
        {
            PauseLock = true;
            pause = true;
            PauseCanvas.gameObject.SetActive(true);
            Debug.Log("Paused");
        }
    }

    void MovetoShop()
    {

    }
}

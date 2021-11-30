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
        
    }
    void ContinuePlaying()
    {
        if(PauseAndShop.pause == true)
        {
            PauseAndShop.pause = false;
            PauseAndShop.PauseLock = false;
            PauseCanvas.gameObject.SetActive(false);           
        }
    }
}

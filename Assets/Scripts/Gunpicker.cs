using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gunpicker : MonoBehaviour    
{
    public static int Manager;
    public Image Main;
    public Image sub;
    // Start is called before the first frame update
    void Start()
    {
        Main.GetComponent<Image>();
        sub.GetComponent<Image>();
        Manager = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Manager = 1;
            sub.color = Color.yellow;
            Main.color = Color.white;
            Debug.Log("Selected SubGun");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Manager = 2;
            Main.color = Color.yellow;
            sub.color = Color.white;
            Debug.Log("Selected MainGun");
        }
    }
}

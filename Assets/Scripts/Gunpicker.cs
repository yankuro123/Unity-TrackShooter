using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunpicker : MonoBehaviour    
{
    public static int Manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Manager = 1;
            Debug.Log("Selected SubGun");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Manager = 2;
            Debug.Log("Selected MainGun");
        }
    }
}

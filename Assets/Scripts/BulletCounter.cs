using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletCounter : MonoBehaviour
{
    public static int Mag;
    public static int MagLeft;
    public float test;
    TMPro.TMP_Text Counter;
    // Start is called before the first frame update
    void Start()
    {
        Mag = StatManager.Magazine;
        MagLeft = Mag;
        Counter = GetComponent<TMP_Text>();
        Gunpicker.Manager = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Gunpicker.Manager == 1)
        {
            if (Firing.reloadingSub == false)
            {
                if (MagLeft <= 10)
                {
                    Counter.color = Color.red;
                    Counter.text = MagLeft + "/" + Mag;
                }
                else
                {
                    Counter.color = Color.white;
                    Counter.text = MagLeft + "/" + Mag;
                }
            }
            else
            {
                Counter.color = Color.white;
                Counter.text = "Reloading";
            } 
        }
        else if (Gunpicker.Manager == 2)
        {
            if (Firing.reloadingMain == false)
            {
                Counter.color = Color.green;
                Counter.text = "Ready";
            }
            else
            {
                Counter.color = Color.red;
                Counter.text = "Reloading";
            }
        }

    }
}

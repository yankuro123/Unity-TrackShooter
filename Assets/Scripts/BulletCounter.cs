using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletCounter : MonoBehaviour
{
    public static int Mag = 100;
    public static int MagLeft = Mag;

    TMPro.TMP_Text Counter;
    // Start is called before the first frame update
    void Start()
    {
        Counter = GetComponent<TMP_Text>();
        Gunpicker.Manager = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Gunpicker.Manager == 1)
        {
            if (Firing.reloading == false)
            {
                if (MagLeft <= 20)
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
            Counter.text = "Ready";
        }

    }
}

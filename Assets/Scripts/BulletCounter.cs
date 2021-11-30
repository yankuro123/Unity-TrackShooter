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
    }

    // Update is called once per frame
    void Update()
    {
        if (Firing.reloading == false)
            Counter.text = MagLeft + "/" + Mag;
        else
            Counter.text = "Reloading";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public static int MoneyStart = 0;
    public static int MoneyCount;
    public static int Bonus;
    public int DebugEnemyCount;
    public int DebugBonus;

    public static int EnemyCounter;

    TMPro.TMP_Text Counter;
    // Start is called before the first frame update
    void Start()
    {     
        MoneyCount = MoneyStart;
        Counter = GetComponent<TMP_Text>();
        InvokeRepeating("MoneyPlus",1.0f,1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        DebugBonus = Bonus;
        DebugEnemyCount = EnemyCounter;
        Counter.text = MoneyCount + "$";
    }
    void MoneyPlus()
    {
        if(PauseAndShop.pause == false)
        {
            MoneyCount += 3;
        }
    }
}

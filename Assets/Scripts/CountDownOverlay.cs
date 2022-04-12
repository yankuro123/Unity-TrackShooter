using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownOverlay : MonoBehaviour
{
    public Image MainOverlay;
    public Image SubOverLay;
    public float TimerMain = 0;
    public float TimerSub = 0;
    // Start is called before the first frame update
    void Start()
    {
        MainOverlay.GetComponent<Image>();
        SubOverLay.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Firing.reloadingMain == true)
        {
            TimerMain += Time.deltaTime;
        }
        else
            TimerMain = 0;
        if (Firing.reloadingSub == true)
        {
            TimerSub += Time.deltaTime;
        }
        else
            TimerSub = 0;
        UpdateCounter();
    }
    public void UpdateCounter()
    {
        MainOverlay.fillAmount = Mathf.Clamp(TimerMain / StatManager.ReloadTimeMain, 0, 1f);
        SubOverLay.fillAmount = Mathf.Clamp(TimerSub / StatManager.ReloadTimeSub, 0, 1f);
    }
}

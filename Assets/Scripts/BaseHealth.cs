using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    public Image HealthBar;
    public BaseLine baseline;

    public void UpdateHealthBar()
    {
        HealthBar.fillAmount = Mathf.Clamp(BaseLine.health / BaseLine.MaxHealth, 0, 1f);
        Debug.Log(BaseLine.health / BaseLine.MaxHealth);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    /*Global - Starting Value for New Game*/
    //Mount
    public static float MaxSpeedStarting = 7.5f;
    public static float AcceleratingStarting = 1.5f;
    public static float MountHealthStarting = 100f;
    //Base
    public static float BaseHealthStarting = 100f;
    public static float BaseRegenStarting = 2f;
    //SubGun
    public static int forceSubStarting = 350;
    public static float FireRateStarting = 0.3f;
    public static int MagazineStarting = 50;
    public static float ReloadTimeSubStarting = 4.5f;
    public static int damgeStarting = 10;
    //Maingun
    public static int forceMainStarting = 300;
    public static float RotatingSpeedStarting = 3f;
    public static float ReloadTimeMainStarting = 1f;
    public static int DamgeStarting = 150;
    //Enemy
    public static float enemyHealthStarting = 30;
    //-------------------------------------------------//
    /*Global - Variable subject to change through Upgrade System*/
    //Mount
    public static float MaxSpeed;
    public static float Accelerating;
    public static float MountHealth;
    //Base
    public static float BaseHealth;
    public static float BaseRegen;
    //SubGun
    public static int forceSub;
    public static float FireRate;
    public static int Magazine;
    public static float ReloadTimeSub;
    public static int damge;
    //Maingun
    public static int forceMain;
    public static float RotatingSpeed;
    public static float ReloadTimeMain;
    public static int Damge;
    //Enemy
    public static float enemyHealth;
    // Start is called before the first frame update
    void Awake()
    {
        //Mount
        MaxSpeed = MaxSpeedStarting;
        Accelerating = AcceleratingStarting;
        MountHealth = MountHealthStarting;
        //Base
        BaseHealth = BaseHealthStarting;
        BaseRegen = BaseRegenStarting;
        //SubGun
        forceSub = forceSubStarting;
        FireRate = FireRateStarting;
        Magazine = MagazineStarting;
        ReloadTimeSub = ReloadTimeSubStarting;
        damge = damgeStarting;
        //Maingun
        forceMain = forceMainStarting;
        RotatingSpeed = RotatingSpeedStarting;
        ReloadTimeMain = ReloadTimeMainStarting;
        Damge = DamgeStarting;
        //Enemy
        enemyHealth = enemyHealthStarting;
    }

    // Update is called once per frame
    void Update()
    {   

    }
}

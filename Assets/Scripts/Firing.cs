using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Firing : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shell;
    public float forceBullet;
    public float forceShell;
    public  float FireRate;
    public Transform firingposSub;
    public Transform firingposMain;
    public Transform target;
    public static bool reloadingSub = false;
    public static bool reloadingMain = false;

    private float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Gunpicker.Manager = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (PauseAndShop.pause == false)
        {
            if (Gunpicker.Manager == 1)
            {
                if (Input.GetMouseButton(0) && Time.time > nextFire)
                {
                    if (BulletCounter.MagLeft > 0 && reloadingSub == false)
                    {
                        nextFire = Time.time + FireRate;
                        Vector2 firingposition = new Vector2(firingposSub.position.x, firingposSub.position.y);
                        GameObject projectile = Instantiate(bullet, firingposition, Quaternion.identity) as GameObject;
                        projectile.GetComponent<Rigidbody2D>().AddForce(firingposSub.up * forceBullet);
                        projectile.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
                        projectile.AddComponent<BoxCollider2D>();
                        projectile.GetComponent<BoxCollider2D>();
                        projectile.GetComponent<BoxCollider2D>().isTrigger = true;
                        BulletCounter.MagLeft -= 1;
                    }
                    else if (BulletCounter.MagLeft == 0 || reloadingSub == true)
                        return;
                }
                if (Input.GetKeyDown(KeyCode.R) && BulletCounter.MagLeft < BulletCounter.Mag || BulletCounter.MagLeft == 0)
                {
                    reloadingSub = true;
                    StartCoroutine(ReloadSub());

                }
            }
            else if (Gunpicker.Manager == 2 && reloadingMain == false)
            {
                Vector2 relativePos = target.position - firingposMain.position;
                Quaternion rotation = Quaternion.LookRotation(Vector3.forward, relativePos);
                if (TurretLookMove.firing == true)
                {
                    Vector2 FiringPosition = new Vector2(firingposMain.position.x, firingposMain.position.y);
                    GameObject projectile = Instantiate(shell, FiringPosition, rotation) as GameObject;
                    //projectile.GetComponent<Rigidbody2D>();
                    //projectile.GetComponent<Rigidbody2D>().AddForce(firingposMain.up * forceShell);
                    projectile.GetComponent<Rigidbody2D>().velocity = ((firingposMain.up * forceShell) / projectile.GetComponent<Rigidbody2D>().mass) * Time.fixedDeltaTime;
                    projectile.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
                    TurretLookMove.firing = false;
                    reloadingMain = true;
                    StartCoroutine(ReloadMain());
                }
                else
                    return;
            }
        }
        else
            return;
    }

    IEnumerator ReloadSub()
    {
        Debug.Log("Reloading Sub");
        yield return new WaitForSeconds(2.0f);
        BulletCounter.MagLeft = BulletCounter.Mag;
        reloadingSub = false;
    }
    IEnumerator ReloadMain()
    {
        Debug.Log("Reloading Main");
        yield return new WaitForSeconds(3.0f);
        reloadingMain = false;
    }
}

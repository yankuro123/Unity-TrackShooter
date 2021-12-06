using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Firing : MonoBehaviour
{
    public GameObject bullet;
    public float force;
    public  float FireRate;
    public Transform firingpos;
    public static bool reloading = false;

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
                    if (BulletCounter.MagLeft > 0 && reloading == false)
                    {
                        nextFire = Time.time + FireRate;
                        Vector2 firingposition = new Vector2(firingpos.position.x, firingpos.position.y);
                        GameObject projectile = Instantiate(bullet, firingposition, Quaternion.identity) as GameObject;
                        projectile.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
                        projectile.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
                        projectile.AddComponent<BoxCollider2D>();
                        projectile.GetComponent<BoxCollider2D>();
                        projectile.GetComponent<BoxCollider2D>().isTrigger = true;
                        projectile.AddComponent<OutOfScreenDestroy>();
                        BulletCounter.MagLeft -= 1;
                    }
                    else if (BulletCounter.MagLeft == 0 || reloading == true)
                        return;
                }
                if (Input.GetKeyDown(KeyCode.R) && BulletCounter.MagLeft < BulletCounter.Mag)
                {
                    reloading = true;
                    StartCoroutine(Reloading());

                }
            }

        }
    }

    IEnumerator Reloading()
    {
        Debug.Log("Reloading");
        yield return new WaitForSeconds(2.0f);
        BulletCounter.MagLeft = BulletCounter.Mag;
        reloading = false;
    }
}

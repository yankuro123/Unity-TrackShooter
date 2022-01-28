using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretLookMove : MonoBehaviour
{
    public Transform Target;
    //public Transform Mark;
    public static Rigidbody2D Marker;
    public float Speed;
    public static bool firing = false;
    public bool firingtest;
    // Start is called before the first frame update
    void Start()
    {
        Target.GetComponent<Transform>();
        Marker = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        firingtest = firing;
        if(Gunpicker.Manager == 1)
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
        }
        if (MainTurret.Marked == false)
        {
            if (Gunpicker.Manager == 2 && Input.GetMouseButtonDown(0))
            {
                Vector2 target = new Vector2(Target.position.x, Target.position.y);
                transform.position = Vector2.MoveTowards(transform.position, target, Speed * Time.deltaTime);
            }

        }
        else
        {
            Transform marker = GameObject.FindGameObjectWithTag("Marker").transform;
            if(transform.position != marker.position)
            {
                transform.position = Vector2.MoveTowards(transform.position, marker.position, Speed * Time.deltaTime);
            }
            else
            {
                MainTurret.Marked = false;
                firing = true;
                GameObject marker1 = GameObject.FindGameObjectWithTag("Marker");
                Object.Destroy(marker1);
            }
          
        }
    }
}

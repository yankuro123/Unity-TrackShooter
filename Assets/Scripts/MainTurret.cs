using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTurret : MonoBehaviour
{
    public Transform Aim;
    public Transform Marker;
    public SpriteRenderer aim;
    public GameObject Mark;
    public static bool Marked;

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Gunpicker.Manager == 2)
        {
            direction = Marker.position - transform.position;
            transform.up = direction;
            aim.GetComponent<SpriteRenderer>().enabled = true;
            Vector2 Cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Aim.position = new Vector2(Cursor.x, Cursor.y);
            if (Input.GetMouseButtonDown(0) && Marked == false)
            {
                GameObject marking = Instantiate(Mark, Aim.position, Quaternion.identity) as GameObject;
                marking.gameObject.GetComponent<Transform>();
                marking.gameObject.GetComponent<Rigidbody2D>();
                Marked = true;
            }
        }
        else
        {
            aim.GetComponent<SpriteRenderer>().enabled = false;
            return;
        }
    }
}

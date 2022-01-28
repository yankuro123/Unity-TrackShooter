using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    public Transform Target;
    public SpriteRenderer target;


    private Vector2 direction;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if(Gunpicker.Manager == 1)
        {
            target.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        target.GetComponent<SpriteRenderer>().enabled = false;
        Vector2 Cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.position = new Vector2(Cursor.x, Cursor.y);
        direction = Target.position - transform.position;
        if (PauseAndShop.pause == false)
        {
            transform.up = direction;
        }
    }
   
}

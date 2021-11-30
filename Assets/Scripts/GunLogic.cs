using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    public Transform reference;
    public float RotationSpeed;
    public Transform Target;


    private Vector2 direction;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;    
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 Cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.position = new Vector2(Cursor.x, Cursor.y);
        direction = Target.position - transform.position;
        transform.up = direction;

    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTurret : MonoBehaviour
{
    public float RotationSpeed;
    public Transform Target;
    public GameObject mark;

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gunpicker.Manager == 2)
        {
            Vector2 Cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Target.position = new Vector2(Cursor.x, Cursor.y);
            if (Input.GetMouseButtonDown(0))
            {
                GameObject marking = Instantiate(mark, Target.position, Quaternion.identity);
            }
        }

    }
}

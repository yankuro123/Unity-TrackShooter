using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountLogic : MonoBehaviour
{
    public static Rigidbody2D Mount;
    public float push = 2.5f;
    public Vector2 moving = new Vector2();
    public float MaxVelocity = 15f;
    public static float retainF;
    public float velocity;

    private float maxX = 11.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Mount = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
            var ForceX = 0f;
            var absVel = Mathf.Abs(Mount.velocity.x);
        if (PauseAndShop.pause == false)
        {
            if (absVel < MaxVelocity)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    moving.x = -1;
                    ForceX = moving.x * push;
                }
                if (Input.GetKey(KeyCode.D))
                {
                    moving.x = 1;
                    ForceX = moving.x * push;
                }
            }
        }
        else
        {
            Mount.velocity = new Vector2(0f, 0f);
        }
        Mount.AddForce(new Vector2(ForceX, 0));
        Vector2 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, -maxX, maxX);
        transform.position = currentPosition;
        velocity = Mount.velocity.x;
    }
}

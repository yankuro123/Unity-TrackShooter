using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollideDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionExit2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
   
}

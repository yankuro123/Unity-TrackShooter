using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellBehavior : MonoBehaviour
{
    private Animator anim;
    public GameObject shell;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        shell.GetComponent<BoxCollider2D>().enabled = true;
        shell.GetComponent<CircleCollider2D>().enabled = false;
        anim.SetInteger("AnimationStates", 0);
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        shell.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0) ;
        if (collision.gameObject.tag == "Enemy")
            anim.SetInteger("AnimationStates", 1);
        else
            return;
    }
    void Explode()
    {
        shell.GetComponent<BoxCollider2D>().enabled = false;
        shell.GetComponent<CircleCollider2D>().enabled = true;
    }
    void Destroy()
    {
        shell.GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(WaitTillDestroy());
    }
    IEnumerator WaitTillDestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}

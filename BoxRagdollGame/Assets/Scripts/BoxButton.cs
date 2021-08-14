using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxButton : MonoBehaviour
{
    public bool isPushed;
    public Animator boxButtonAnim;

    void Update()
    {
        //Debug.Log(isPushed.ToString());
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Grabbable")
        {
            boxButtonAnim.Play("pushDown");
            isPushed = true;
        }
        else 
        {
            boxButtonAnim.Play("idle");
            isPushed = false;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Grabbable")
        {
            boxButtonAnim.Play("pushUp");
            isPushed = false;
        }
        else 
        {
            boxButtonAnim.Play("idle");
            isPushed = false;
        }
    }
}

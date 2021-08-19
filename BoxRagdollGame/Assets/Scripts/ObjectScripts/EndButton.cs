using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    public bool isPushed;
    public Animator endButtonAnim;

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name.ToString());
        if (col.gameObject.CompareTag("Player")) 
        {
            endButtonAnim.Play("pushDown");
            Debug.Log("pushDown");
            isPushed = true;
        }
        else
        {
            Debug.Log("idle");
            endButtonAnim.Play("idle");
            isPushed = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name.ToString());
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("pushUp");
            endButtonAnim.Play("pushUp");
            isPushed = false;
        }
        else
        {
            Debug.Log("idle");
            endButtonAnim.Play("idle");
            isPushed = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxButton : MonoBehaviour
{
    public bool isPushed;
    public Animator boxButtonAnim;

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name.ToString());
        if (col.gameObject.CompareTag("Grabbable"))
        {
            boxButtonAnim.Play("pushDown");
            Debug.Log("pushDown");
            isPushed = true;
        }
        else 
        {
            Debug.Log("idle");
            boxButtonAnim.Play("idle");
            isPushed = false;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name.ToString());
        if (col.gameObject.CompareTag("Grabbable"))
        {
            Debug.Log("pushUp");
            boxButtonAnim.Play("pushUp");
            isPushed = false;
        }
        else 
        {
            Debug.Log("idle");
            boxButtonAnim.Play("idle");
            isPushed = false;
        }
    }

}

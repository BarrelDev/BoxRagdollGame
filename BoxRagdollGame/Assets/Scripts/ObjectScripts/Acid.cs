using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Acid : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject collided = col.gameObject;
        //Debug.Log(collided.name);
        if (collided.name == "Hips")
        {
            collided.GetComponent<Balence>().enabled = false;
            collided.GetComponentInParent<PlayerController>().enabled = false;
            collided.GetComponentInParent<Animator>().Play("idle");
            GameObject parent = collided.transform.parent.gameObject;
            Debug.Log(parent.name);

            Component[] children = parent.GetComponentsInChildren<Arms>();
            foreach (Arms arm in children) 
            {
                arm.enabled = false;
            }
            children = parent.GetComponentsInChildren<Grab>();
            foreach (Grab hand in children) 
            {
                hand.enabled = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Acid : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject collided = col.gameObject;
        if (collided.name == "Hips")
        {
            collided.GetComponent<Balence>().enabled = false;
            collided.GetComponentInParent<PlayerController>().enabled = false;
            collided.GetComponent<Animator>().Play("idle");
            GameObject parent = col.gameObject.transform.parent.gameObject;
            parent.GetComponentInChildren<Arms>().enabled = false;
            parent.GetComponentInChildren<Grab>().enabled = false;
        }
    }
}

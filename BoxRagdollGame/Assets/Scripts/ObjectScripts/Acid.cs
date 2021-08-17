using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Acid : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Hips")
        {
            col.gameObject.GetComponent<Balence>().enabled = false;
            col.gameObject.GetComponentInParent<PlayerController>().enabled = false;
        }
    }
}

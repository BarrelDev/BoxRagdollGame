using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balence : MonoBehaviour
{
    public float targetRotation;
    public Rigidbody2D rb;
    public float force;

    public void Update()
    {
        if (rb.rotation != targetRotation) 
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, targetRotation, force * Time.fixedDeltaTime));
        }
    }
}

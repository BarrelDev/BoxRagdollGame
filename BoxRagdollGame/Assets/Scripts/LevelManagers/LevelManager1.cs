using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager1 : MonoBehaviour
{
    public Animator entranceDoor;
    // Start is called before the first frame update
    void Start()
    {
        entranceDoor.Play("open");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

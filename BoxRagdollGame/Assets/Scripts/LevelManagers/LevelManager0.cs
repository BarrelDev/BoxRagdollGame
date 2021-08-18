using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager0 : MonoBehaviour
{
    public BoxButton boxButton;
    public EndButton endButton;
    public GameObject platform;
    public GameObject acid;
    public Animator exitDoor;
    private bool LevelFlag0;
    private bool LevelFlag1;

    void Start()
    {
        LevelFlag0 = false;
        LevelFlag1 = false;
    }

    void Update()
    {
        if (boxButton.isPushed && !LevelFlag0) 
        {
            platform.transform.position = new Vector2(acid.transform.position.x-10f, acid.transform.position.y);
            Rigidbody2D pRB = platform.GetComponent<Rigidbody2D>();
            pRB.AddForce(new Vector2(0f, 5f));
            LevelFlag0 = true;
        }
        if (endButton.isPushed && !LevelFlag1)
        {
            exitDoor.Play("open");
        }
    }
}

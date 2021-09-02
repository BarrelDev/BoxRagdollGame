using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager0 : MonoBehaviour
{
    public BoxButton boxButton;
    public EndButton endButton;
    public GameObject platform;
    public GameObject acid;
    public Animator exitDoor;
    public Animator levelFade;
    public LevelChanger levelChanger;
    private bool HasCrossedAcid;
    private bool PressedEndButton;

    void Start()
    {
        HasCrossedAcid = false;
        PressedEndButton = false;
    }

    void Update()   
    {
        if (boxButton.isPushed && !HasCrossedAcid) 
        {
            platform.transform.position = new Vector2(acid.transform.position.x-10f, acid.transform.position.y);
            Rigidbody2D pRB = platform.GetComponent<Rigidbody2D>();
            pRB.AddForce(new Vector2(0f, 5f));
            HasCrossedAcid = true;
        }
        if (endButton.isPushed && !PressedEndButton)
        {
            exitDoor.Play("open");
            Debug.Log("open");
            PressedEndButton = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        levelChanger.FadeToLevel(1);
    }
    
}

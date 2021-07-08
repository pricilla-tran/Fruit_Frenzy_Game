using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float speed;
    public bool isDynamite;
    public int itemPoints;
    public GameControl myGame;
    public AudioSource myAudioSource;
    public AudioClip myClip;

    // Start is called before the first frame update
    void Start()
    {
        // instead of clicking and dragging, we use GetComponent to link the object's RigidBody2D component to the script
        myRigid = GetComponent<Rigidbody2D>();
        // searches for a game object with name GameManager and gets the GameControl component attached
        myGame = GameObject.Find("GameManager").GetComponent<GameControl>();
        // finds game object named Audio Source and gets the AudioSource component from it 
        myAudioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        Spawn();
    } 

    void Spawn()
    {
        // 1. sets position 
        // 2. sets velocity 
        transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-4, 4), 0);
        // Normalise when we pick random point inside circle 
        myRigid.velocity = Random.insideUnitCircle.normalized * speed;
    }

    void OnMouseDown()
    {
        if (isDynamite)
        {
            //game over
            myGame.GameOver();
        }
        else
        {
            // add points
            myGame.AddPoints(itemPoints);
            // trigger sound when an item is clicked on
            // PlayOneShot will play Audio Clip once
            myAudioSource.PlayOneShot(myClip);
            Spawn();
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        
    } */
}

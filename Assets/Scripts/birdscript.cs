using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;

    public AudioSource audios;
   
    public playerscore logic;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<playerscore>();
        audios=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && birdAlive)

        {
            audios.Play();
            myRigidbody.velocity = Vector2.up * flapstrength;
            
        }
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdAlive = false;
    }

}
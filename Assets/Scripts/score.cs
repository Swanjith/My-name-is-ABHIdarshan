using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerscore : MonoBehaviour
{
    public int Playerscore;
    public Text scoretext;
    public AudioSource audioSource;
    public AudioClip scoreClip;
    public AudioSource bg;
    public GameObject gameoverscreen;
    [ContextMenu("score added")]
    void Start()
    {
        bg = GetComponent<AudioSource>();
    }
    public void addScore()
    {
        Playerscore = Playerscore + 1;
        scoretext.text = Playerscore.ToString();
        
    }
    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        if (bg != null)
        {
            bg.Stop();

        }
        audioSource.PlayOneShot(scoreClip);
        gameoverscreen.SetActive(true);
        Time.timeScale = 0f;
        
    }
}
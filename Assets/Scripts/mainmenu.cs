using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    
    public void Playgame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Exit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
     
    }
}using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    
    public void Playgame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Exit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
     
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Game()
    {
        SceneManager.LoadScene(2);
    }

    public void Quite()
    {
        Application.Quit();
    }

    public void End()
    {
        
        Debug.Log("Load");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    
    }

}

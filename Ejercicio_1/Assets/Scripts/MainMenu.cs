using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void Play(string Name)
    {
        SceneManager.LoadScene(Name);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}

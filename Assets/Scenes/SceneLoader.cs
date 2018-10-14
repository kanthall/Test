using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameplay()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadStart()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Next()
    {
        SceneManager.LoadScene(2);
    }
}

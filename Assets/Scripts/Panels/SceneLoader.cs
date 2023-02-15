using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void PlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
    
    public void ReloadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void RestartScene()
    {
        Time.timeScale = 1.0f;
        string currentName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

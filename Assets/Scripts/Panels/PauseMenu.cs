using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _gamePlayPanel;

    //[SerializeField] private AudioMixerGroup _mixer;

    public void ToggleMusic(bool enable)
    {

    }

    public void PauseButton()
    {
        _pausePanel.SetActive(true);
        _gamePlayPanel.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeButton()
    {
        _pausePanel.SetActive(false);
        _gamePlayPanel.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main");
    }
}

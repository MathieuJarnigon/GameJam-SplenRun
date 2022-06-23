using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject StartUI;
    public GameObject MainMenuUI;
    public GameObject DressingUI;
    public AudioSource clickAudio;

    public void startUI()
    {
        clickAudio = GetComponent<AudioSource>();
        clickAudio.Play(0);
        MainMenuUI.SetActive(false);
        StartUI.SetActive(true);
    }

    public void QuitGame()
    {
        clickAudio = GetComponent<AudioSource>();
        clickAudio.Play(0);
        Application.Quit();
    }

    public void Dressing()
    {
        clickAudio = GetComponent<AudioSource>();
        clickAudio.Play(0);
        MainMenuUI.SetActive(false);
        DressingUI.SetActive(true);
    }

    public void TutorielLevel()
    {
        clickAudio = GetComponent<AudioSource>();
        clickAudio.Play(0);
        SceneManager.LoadScene("SampleScene");
    }

    public void LevelOne()
    {
        clickAudio = GetComponent<AudioSource>();
        clickAudio.Play(0);
        SceneManager.LoadScene("Level1");
    }

    public void Back()
    {
        clickAudio = GetComponent<AudioSource>();
        clickAudio.Play(0);
        MainMenuUI.SetActive(true);
        DressingUI.SetActive(false);
        StartUI.SetActive(false);
    }
}

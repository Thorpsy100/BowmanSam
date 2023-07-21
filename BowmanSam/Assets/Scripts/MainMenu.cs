using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource soundPlayer;
    public AudioClip exitSound;

    void Start()
    {
        //Connects to the audio source component in Unity
        soundPlayer = GetComponent<AudioSource>();
    }
    private void LoadNextScene()
    {
        //When pressing play loads the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayGame()
    {
        //Makes the sound for pressing the button, invoke for delay so it doesn't cut out
        soundPlayer.Play();
        Invoke("LoadNextScene", 0.5f);
    }
    private void ExitGame()
    {
        //Quits game
        Application.Quit();
    }
    public void QuitGame()
    {
        //Exit game sound with delay
        soundPlayer.clip = exitSound;
        soundPlayer.Play();
        Invoke("ExitGame", 0.5f);
    }
}
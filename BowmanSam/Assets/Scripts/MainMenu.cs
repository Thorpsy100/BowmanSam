using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

    private IEnumerator LoadScene(int index)
    {
        // Wait
        yield return new WaitForSeconds(0.5f);
        // Load scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);

    }
    public void PlayGame()
    {
        //Makes the sound for pressing the button, invoke for delay so it doesn't cut out
        soundPlayer.Play();
        StartCoroutine(LoadScene(1));
        //Invoke(nameof(LoadNextScene), 0.5f);
    }

    public void PlayGameHard()
    {
        //Makes the sound for pressing the button, invoke for delay so it doesn't cut out
        soundPlayer.Play();
        StartCoroutine(LoadScene(2));

    }
    public void PlayGameRelax()
    {
        //Makes the sound for pressing the button, invoke for delay so it doesn't cut out
        soundPlayer.Play();
        StartCoroutine(LoadScene(3));
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


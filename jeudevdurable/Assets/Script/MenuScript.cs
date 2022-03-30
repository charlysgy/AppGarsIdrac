using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private AudioSource ac;
    public bool music;

    private void Start()
    {
        ac = GetComponent<AudioSource>();
        music = false;
    }

    public void OnClickMusicOff()
    {
        ac.Pause();
    }

    public void OnClickMusicOn()
    {
        ac.Play();
    }

    public void OnClickGameOne()
    {
        SceneManager.LoadScene("Game1");
    }
    public void OnClickGameTwo()
    {
        SceneManager.LoadScene("Game2");
    }
    public void OnClickExit()
    {
        Application.Quit();
    }
}

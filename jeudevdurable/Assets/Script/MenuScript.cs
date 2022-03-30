using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private AudioSource ac;
    public bool music = true;
    private GameObject[] acS;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        acS = GameObject.FindGameObjectsWithTag("MainCamera");
        if (acS.Length > 1)
        {
            Destroy(this.gameObject);
        }

        ac = GetComponent<AudioSource>();
        if (music)
        {
            ac.Play();
        }
    }

    public void OnClickMusicOff()
    {
        music = false;
        ac.Pause();
    }

    public void OnClickMusicOn()
    {
        if (!music)
        {
            music = true;
            ac.Play();
        }
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

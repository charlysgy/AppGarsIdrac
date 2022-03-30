using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGame1 : MonoBehaviour
{
    private GameObject mainCamera;

    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    public void OnClickRestart()
    {
        SceneManager.LoadScene("Game1");
    }

    public void OnClickMenu()
    {
        Destroy(mainCamera);
        SceneManager.LoadScene("Menu");
    }
}

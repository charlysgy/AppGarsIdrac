using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGame2 : MonoBehaviour
{
    private GameObject mainCamera;

    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    public void OnClickBackMenu()
    {
        Destroy(mainCamera);
        SceneManager.LoadScene("Menu");
    }
    public void OnClickRestart()
    {
        SceneManager.LoadScene("Game2");
    }
}

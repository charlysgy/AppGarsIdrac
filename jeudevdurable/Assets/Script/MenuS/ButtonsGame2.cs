using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGame2 : MonoBehaviour
{
    public void OnClickBackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OnClickRestart()
    {
        SceneManager.LoadScene("Game2");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsGame1 : MonoBehaviour
{
    public void OnClickRestart()
    {
        SceneManager.LoadScene("Game1");
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

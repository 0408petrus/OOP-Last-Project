using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuHandler : MonoBehaviour
{
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void StartNew()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

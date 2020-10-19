using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        if(SceneManager.GetActiveScene().buildIndex <= 6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene("FinishScene");
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Controlls()
    {
        SceneManager.LoadScene("ControllsScene");
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}

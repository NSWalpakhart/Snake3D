using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void OnPlayHandler()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnExitHandler()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelCanvas;
    private void Start()
    {
        panelCanvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePanel();
        }
    }

    public void TogglePanel()
    {
        panelCanvas.SetActive(!panelCanvas.gameObject.activeSelf);
        Time.timeScale = (panelCanvas.gameObject.activeSelf) ? 0f : 1f;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

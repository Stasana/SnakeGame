using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScenceAndMenu : MonoBehaviour
{

    public GameObject buttonsMenu;
    public GameObject buttonsExit;
    public GameObject buttonsStart;

    void Start()
    {

    }

    void Update()
    {

    }

    public void ShowStartButtons()
    {
        buttonsMenu.SetActive(false);
        buttonsStart.SetActive(true);
    }

    public void EasyGame()
    {
        Application.LoadLevel("SnakeEasyGame");
    }

    public void MediumGame()
    {
        Application.LoadLevel("SnakeMediumGame");
    }

    public void HardGame()
    {
        Application.LoadLevel("SnakeHardGame");
    }

    public void ShowExitButtons()
    {
        buttonsMenu.SetActive(false);
        buttonsExit.SetActive(true);
    }

    public void BackInMenu()
    {
        buttonsMenu.SetActive(true);
        buttonsExit.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }

    public void loadMenu()
    {
        Application.LoadLevel("Menu");
    }

}
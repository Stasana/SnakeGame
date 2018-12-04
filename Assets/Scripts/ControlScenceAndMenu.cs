using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScenceAndMenu : MonoBehaviour {

	public GameObject buttonsMenu;
	public GameObject buttonsExit;

	void Start()
	{

	}

	void Update()
	{

	}

    public void ShowExitButtons(){
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

    public void NewGameLoadScenceSnakeGame()
    {
        Application.LoadLevel("SnakeGame");
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour

{
    public bool pauseToggle;
    public GameObject PauseTittle;


    void Start()
    {
        pauseToggle = false;
        PauseTittle = GameObject.FindGameObjectWithTag("PauseTittle");
        PauseTittle.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (pauseToggle)
            {
                Time.timeScale = 1;
                PauseTittle.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                PauseTittle.SetActive(true);
            }

            pauseToggle = !pauseToggle;
        }
    }
}
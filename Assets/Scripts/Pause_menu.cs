using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_menu : MonoBehaviour
{
    public GameObject pause_menu;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause_menu.SetActive(true);
        }
    }

    public void Resume()
    {
        pause_menu.SetActive(false);
    }

    public void Quit_game()
    {
        Application.Quit();
    }
}

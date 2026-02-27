using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] PauseButton pauseButton;

    public void Clicked()
    {
        Time.timeScale = 1;
        pauseMenu.GetComponent<SettingPanel>().DisapearRN();
        pauseButton.Appear();
    }
}

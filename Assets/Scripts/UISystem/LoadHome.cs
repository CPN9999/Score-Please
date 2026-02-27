using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHome : MonoBehaviour
{
    bool check = false;
    private void OnEnable()
    {
        AddHomeFunc.OnHomeButtonPressed += LoadMainMenu;
        DisapearPanel.DisapearDone += HandleDisapearDone;
    }

    private void OnDisable()
    {
        AddHomeFunc.OnHomeButtonPressed -= LoadMainMenu;
        DisapearPanel.DisapearDone -= HandleDisapearDone;
    }

    private void LoadMainMenu()
    {
        check = true;
        SceneManager.LoadScene(0); //Load main menu
    }

    private void HandleDisapearDone(DisapearPanel panel)
    {
        if (check)
        {
            SceneManager.LoadScene(0); //Load main menu
            check = false; //Reset check sau khi load xong
        }
    }
}

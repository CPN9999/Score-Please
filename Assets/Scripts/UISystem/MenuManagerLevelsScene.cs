using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManagerLevelsScene : MonoBehaviour
{
    GameObject[] disablePanel;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject gamename;

    int count = 0;
    Action afterTransitionAction;

    private void OnEnable()
    {
        DisapearPanel.DisapearDone += OnFinished;
    }

    private void OnDisable()
    {
        DisapearPanel.DisapearDone -= OnFinished;
    }

    public void StartTransition(Action action)
    {
        count = 0;
        afterTransitionAction = action;
        disablePanel = GameObject.FindGameObjectsWithTag("LevelButton");
        foreach (var panel in disablePanel)
        {
            panel.GetComponent<DisapearPanel>().DisapearRN();
        }
        gamename.GetComponent<DisapearPanel>().DisapearRN();
        backButton.GetComponent<DisapearPanel>().DisapearRN();
    }

    private void OnFinished(DisapearPanel panel)
    {
        count++;

        if (count >= disablePanel.Length)
        {
            afterTransitionAction?.Invoke();
        }
    }
}
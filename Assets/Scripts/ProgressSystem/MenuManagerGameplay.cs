using System;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerGameplay : MonoBehaviour
{
    [SerializeField] List<DisapearPanelGameplay> panels;

    int count = 0;
    Action afterTransitionAction;

    private void OnEnable()
    {
        DisapearPanelGameplay.DisapearDone += OnFinished;
    }

    private void OnDisable()
    {
        DisapearPanelGameplay.DisapearDone -= OnFinished;
    }

    public void StartTransition(Action action)
    {
        count = 0;
        afterTransitionAction = action;
        foreach (var panel in panels)
        {
            panel.DisapearRN();
        }
    }

    private void OnFinished(DisapearPanelGameplay panel)
    {
        count++;

        if (count >= panels.Count)
        {
            afterTransitionAction?.Invoke();
        }
    }
}
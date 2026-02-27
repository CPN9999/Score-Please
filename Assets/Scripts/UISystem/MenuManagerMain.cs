using System;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagerMain : MonoBehaviour
{
    [SerializeField] List<DisapearPanel> panels;

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
        foreach (var panel in panels)
        {
            panel.DisapearRN();
        }
    }

    private void OnFinished(DisapearPanel panel)
    {
        count++;

        if (count >= panels.Count)
        {
            afterTransitionAction?.Invoke();
        }
    }
}
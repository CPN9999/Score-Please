using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using FGUIStarter;
using UnityEditor.PackageManager;
using UnityEngine;

public class DisapearPanel : MonoBehaviour
{
    public int targetSceneIndex;
    public static event Action<DisapearPanel> DisapearDone; 
    private float duration = 0.2f; 
    private void OnEnable()
    {
        CustomButton.OnCustomButtonPressed += DisapearRN;
    }

    private void OnDisable()
    {
        CustomButton.OnCustomButtonPressed -= DisapearRN;
    }

    private void DisapearRN(CustomButton button)
    {
        targetSceneIndex = button.targetSceneIndex;
        transform.DOScale(Vector3.zero, duration)
                .SetEase(Ease.InBack).OnComplete(SetAfterDone);
    }

    private void SetAfterDone()
    {
        this.gameObject.SetActive(false);
        DisapearDone?.Invoke(this);
    }
}

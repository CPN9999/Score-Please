using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DisapearPanelGameplay : MonoBehaviour
{
    public static event Action<DisapearPanelGameplay> DisapearDone;
    private float duration = 0.2f;

    public void DisapearRN()
    {
        transform.DOScale(Vector3.zero, duration)
              .SetEase(Ease.InBack).OnComplete(SetAfterDone);
    }

    private void SetAfterDone()
    {
        gameObject.SetActive(false);
        DisapearDone?.Invoke(this);
    }
}

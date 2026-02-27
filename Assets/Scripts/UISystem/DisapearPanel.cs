using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using FGUIStarter;
using UnityEngine;

public class DisapearPanel : MonoBehaviour
{
    public static event Action<DisapearPanel> DisapearDone;
    private float duration = 0.2f;
    [SerializeField] float scaleX=1f;
    [SerializeField] float scaleY=1f;
    [SerializeField] float scaleZ=1f;

    private void Awake()
    {
        transform.DOKill();
        transform.localScale = Vector3.zero;
        transform.DOScale(new Vector3(scaleX,scaleY,scaleZ), 0.5f)
                 .SetEase(Ease.OutBack);
    }

    public void DisapearRN()
    {
        transform.DOScale(Vector3.zero, duration)
                .SetEase(Ease.InBack).OnComplete(SetAfterDone);
    }

    private void SetAfterDone()
    {
        this.gameObject.SetActive(false);
        DisapearDone?.Invoke(this);
    }
}

using DG.Tweening;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    [SerializeField] RectTransform panel; 

    private float duration = 0.2f;
    private Vector3 originalScale;

    private void Awake()
    {
        originalScale = panel.localScale;
    }

    public void DisapearRN()
    {
        panel.DOKill();
        panel.DOScale(Vector3.zero, duration)
             .SetEase(Ease.InBack)
             .OnComplete(AniDone);
    }

    private void AniDone()
    {
        panel.gameObject.SetActive(false);
    }

    public void Appear()
    {
        panel.gameObject.SetActive(true);

        panel.DOKill();
        panel.localScale = Vector3.zero;

        panel.DOScale(originalScale, duration)
             .SetEase(Ease.OutBack)
             .SetUpdate(true);   
    }
}
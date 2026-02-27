using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseButton : MonoBehaviour
{
    [SerializeField ] GameObject PauseMenu;
    [SerializeField] private MenuManagerGameplay manager;
    public void Clicked()
    {

        manager.StartTransition(Pause);
    }

    private void Pause()
    {
        PauseMenu.GetComponent<SettingPanel>().Appear();
        Time.timeScale = 0.0001f;
    }

    public void Appear()
    {
        transform.localScale = Vector3.zero;
        transform.DOScale(new Vector3(1.6082f, 1.6082f, 1.6082f), 0.5f)
                 .SetEase(Ease.OutBack);

        this.gameObject.SetActive(true);
    }
}

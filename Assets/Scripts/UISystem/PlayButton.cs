using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private MenuManagerMain manager;

    public void Clicked()
    {
        manager.StartTransition(LoadScene);
    }

    private void LoadScene()
    {
        MySceneManager.instance.LoadScene(1);
    }
}

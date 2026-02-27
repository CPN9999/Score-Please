using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    [SerializeField] private MenuManagerMain manager;

    public void Clicked()
    {
        manager.StartTransition(QuitNow);
    }

    private void QuitNow()
    {
        Application.Quit();
    }
}

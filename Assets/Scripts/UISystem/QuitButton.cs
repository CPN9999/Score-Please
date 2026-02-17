using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    Button button;
    void Awake()
    {
           button = this.GetComponent<Button>();
    }
    private void Start()
    {
        button.onClick.AddListener(QuitGame);
    }
    private void QuitGame()
    {
        Application.Quit();
    }
}

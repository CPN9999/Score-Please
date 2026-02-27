using System;
using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;

public class AddHomeFunc : MonoBehaviour
{
    public static event Action OnHomeButtonPressed;

    public void HomeButtonPressed()
    {
        OnHomeButtonPressed?.Invoke();
    }
}

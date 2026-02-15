using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController: MonoBehaviour
{  
    public static event Action<BallController> OnBallEnterBasket;

    public void EnterBasket()
    {
        OnBallEnterBasket?.Invoke(this);
    }
}

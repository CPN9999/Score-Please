using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController: MonoBehaviour
{  
    public static event Action<BallController> OnBallEnterBasket;
    public static event Action<BallController> OnBallOutOfScreen;

    public void EnterBasket()
    {
        OnBallEnterBasket?.Invoke(this);
    }
    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
        OnBallOutOfScreen?.Invoke(this);
    }
}

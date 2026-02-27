using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    public int numberOfBallsInBasket = 0;
    public GameObject winPanel;
    public bool isLose= false;
    private ILoseCondition checkLose;

    private void Awake()
    {
        this.numberOfBallsInBasket = 0;
    }

    private void Start()
    {
        checkLose = this.GetComponent<ILoseCondition>();
    }
    private void OnEnable()
    {
        BallController.OnBallEnterBasket += CheckWinCondition;
    }

    private void OnDisable()
    {
        BallController.OnBallEnterBasket -= CheckWinCondition;
    }

    private void CheckWinCondition(BallController ballController)
    {
        if (isLose) return;
        this.numberOfBallsInBasket++;
        if (this.numberOfBallsInBasket >= LevelManager.Instance.numberOfBallsToWin)
        {
            winPanel.SetActive(true);
            checkLose.isWin = true;
        }
    }
}

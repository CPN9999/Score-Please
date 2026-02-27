using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ILoseCondition : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    public int numberOfBallsOut = 0;
    private CheckWin checkWin;
    public bool isWin = false;

    private void Start()
    {
        checkWin = this.GetComponent<CheckWin>();
    }
    private void OnEnable()
    {
        BallController.OnBallOutOfScreen += Lose;
    }
    private void OnDisable()
    {
        BallController.OnBallOutOfScreen -= Lose;
    }
    public void Lose(BallController ball)
    {
        if (isWin) return;
        this.numberOfBallsOut++;
        if (this.numberOfBallsOut >= checkWin.numberOfBallsInBasket)
        {
            losePanel.SetActive(true);
            checkWin.isLose = true;
        }
    }

    public void LoseManual()
    {
        losePanel.SetActive(true);
        checkWin.isLose = true;
    }
}

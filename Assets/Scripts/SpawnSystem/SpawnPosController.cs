using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosController : MonoBehaviour
{
    public GameObject ballPrefab;
    public int ballCount;
    int ballCount2;

    public void Init(GameObject ballPrefab, int ballCount)
    {
        this.ballPrefab = ballPrefab;
        this.ballCount = ballCount;
        ballCount2 = ballCount;
        StartCoroutine(SpawnBall());
    }

    private IEnumerator SpawnBall()
    {
        while (ballCount2>0)
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
            ballCount2--;
            yield return new WaitForSeconds(0.01f);
        }
    }
}

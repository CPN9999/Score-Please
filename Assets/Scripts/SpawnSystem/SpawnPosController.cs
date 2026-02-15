using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosController : MonoBehaviour
{
    public GameObject ballPrefab;
    public int ballCount;

    private void OnEnable()
    {
        LevelManager.LevelLoaded += OnLevelLoaded;
        if (LevelManager.Instance != null && LevelManager.Instance.isLoaded)
        {
            OnLevelLoaded(LevelManager.Instance);
        }
    }

    private void OnDisable()
    {
        LevelManager.LevelLoaded -= OnLevelLoaded;
    }

    private void OnLevelLoaded(LevelManager levelManager)
    {   
        StartCoroutine(SpawnBall());
    }

    private IEnumerator SpawnBall()
    {
        while (ballCount>0)
        {
            Instantiate(ballPrefab, transform.position, Quaternion.identity);
            ballCount--;
            yield return new WaitForSeconds(0.01f);
        }
    }
}

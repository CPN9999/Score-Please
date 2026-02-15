using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreyBallController : MonoBehaviour
{
    public GameObject ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Instantiate(ball, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

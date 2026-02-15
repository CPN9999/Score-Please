using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Ball entered the basket");
            BallController ballController = collision.gameObject.GetComponent<BallController>();
            if (ballController != null)
            {
                ballController.EnterBasket();
                //// Check if the ball is grey and not already in the basket
                //if (ballController.isGrey() && !ballController.isInBasket())
                //{
                //    // Mark the ball as being in the basket
                //    // You can add any additional logic here, such as updating score or triggering events
                //}
            }
        }
    }
}

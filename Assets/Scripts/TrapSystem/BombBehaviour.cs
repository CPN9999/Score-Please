using System.Collections;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    public float explosionRadius = 3f;
    public LayerMask destroyLayer;   
    public GameObject explosionEffect;
    bool isLose = false;

    private bool canExplode = false;


    private void Start()
    {
        StartCoroutine(EnableCollisionAfterDelay(1f));
    }

    IEnumerator EnableCollisionAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        canExplode = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!canExplode)
        {
            return;
        }
        else
        {
            Explode();
        }
    }

    public void Explode()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }


        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, explosionRadius, destroyLayer);
        if (hits.Length > 0) { isLose = true; }
        foreach (Collider2D hit in hits)
        {
                Destroy(hit.gameObject);
        }
        if (isLose)
        {
            GameObject manager =GameObject.Find("GameManager");
            manager.GetComponent<ILoseCondition>().LoseManual();
        }
 
        Destroy(gameObject);
    }
}
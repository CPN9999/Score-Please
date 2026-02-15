using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isPulled = false;
    private Vector3 targetPosition;
    private Vector3 Dir;

    private void OnMouseDown()
    {
        Pull();
    }

    public void Pull()
    {
        if (isPulled) return;

        isPulled = true;

        targetPosition = transform.localPosition + Vector3.down * 2f;
        Dir = (targetPosition - transform.localPosition).normalized;
        Debug.Log(targetPosition);
    }

    private void Update()
    {
        if (!isPulled) return;
        transform.localPosition += Dir * Time.deltaTime * 10f;
    }

    private void OnBecameInvisible()
    {
        if (!isPulled) return;
        this.gameObject.SetActive(false);
    }
}

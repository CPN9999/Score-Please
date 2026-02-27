using UnityEngine;

public class PinController : MonoBehaviour
{
    private bool isPulled = false;
    private Vector3 targetPosition;
    private Vector3 Dir;
    [SerializeField] GameObject pin;

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
    }

    private void Update()
    {
        if (!isPulled) return;
        transform.localPosition += Dir * Time.deltaTime * 10f;
        pin.transform.localPosition += Dir * Time.deltaTime * 10f;
    }

    private void OnBecameInvisible()
    {
        if (!isPulled) return;
        this.gameObject.SetActive(false);
    }
}

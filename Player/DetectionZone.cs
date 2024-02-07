using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    private bool _isEnter;

    public bool IsEnter => _isEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
            _isEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>())
            _isEnter = false;
    }
}

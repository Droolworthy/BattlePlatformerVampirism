using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Wellness;
    [SerializeField] float _speed;

    private Coroutine _coroutine;

    public void ChangeValue(int value, int maxHealth)
    {
        float targetValue = Wellness.value;

        targetValue = (float)value / maxHealth;

        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(TransformWellnessLevel(targetValue));
    }

    private IEnumerator TransformWellnessLevel(float targetValue)
    {
        bool isWork = true;

        while (isWork)
        {
            Wellness.value = Mathf.MoveTowards(Wellness.value, targetValue, _speed * Time.deltaTime);

            if (Wellness.value == targetValue)
            {
                isWork = false;
            }

            yield return null;
        }

        StopCoroutine(_coroutine);
    }
}

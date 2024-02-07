using UnityEngine;
using UnityEngine.UI;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Slider Wellness;

    public void OnValueChanged(int value, int maxValue)
    {
        Wellness.value = (float)value / maxValue;
    }
}

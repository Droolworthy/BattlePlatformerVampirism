using UnityEngine;

public class HealthBarPlayer : Bar
{
    [SerializeField] private Player _gamer;

    private void OnEnable()
    {
        _gamer.PlayerHealthChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _gamer.PlayerHealthChanged -= ChangeValue;
    }
}

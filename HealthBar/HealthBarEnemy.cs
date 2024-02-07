using UnityEngine;

public class HealthBarEnemy : Bar
{
    [SerializeField] private Enemy _foe;

    private void OnEnable()
    {
        _foe.EnemyHealthChanged += ChangeValue;

        Wellness.value = 1;
    }

    private void OnDisable()
    {
        _foe.EnemyHealthChanged -= ChangeValue;
    }
}

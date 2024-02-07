using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _currentHealth;

    public UnityAction<int, int> PlayerHealthChanged;

    private void Start()
    {
        _currentHealth = _health;
    }

    public void TakeHealthEnemy(int health)
    {
        _currentHealth += health;

        PlayerHealthChanged?.Invoke(_currentHealth, _health);
    }
}

using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _currentHealth;

    public UnityAction<int, int> EnemyHealthChanged;

    private void Start()
    {
        _currentHealth = _health;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        
        EnemyHealthChanged?.Invoke(_currentHealth, _health);

        if (_currentHealth <= 0)
            Destroy(gameObject);
    }
}

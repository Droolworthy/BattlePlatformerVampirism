using System.Collections;
using UnityEngine;

public class TakeHealthEnemy : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private int _delay;

    private Coroutine _coroutine;

    public void Play(Enemy enemy, Player player)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(SelectWellnessOpponent(enemy, player, _delay));
    }

    private IEnumerator SelectWellnessOpponent(Enemy enemy, Player player, int delay)
    {
        int startDelay = 0;

        while (startDelay <= delay)
        {
            startDelay++;

            enemy.TakeDamage(_damage);

            player.TakeHealthEnemy(_damage);

            yield return null;
        }

        StopCoroutine(_coroutine);
    }
}

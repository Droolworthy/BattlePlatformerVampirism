using UnityEngine;

public class TakeHealthEnemyButton : MonoBehaviour
{
    [SerializeField] private DetectionZone _detectionZone;
    [SerializeField] private TakeHealthEnemy _selectWellness;
    [SerializeField] private Player _player;
    [SerializeField] private Enemy _foe;

    public void SelectWellnessOpponent()
    {
        if (_detectionZone.IsEnter == true)
            _selectWellness.Play(_foe, _player);
    }
}

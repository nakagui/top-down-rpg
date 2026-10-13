using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;

    public float Damage => _damage;
    public float Speed => _speed;
}

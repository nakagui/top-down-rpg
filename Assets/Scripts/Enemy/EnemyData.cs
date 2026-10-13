using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float _maxHP;
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;

    public float MaxHP => _maxHP;
    public float Damage => _damage;
    public float Speed => _speed;
}

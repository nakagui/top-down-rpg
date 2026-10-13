using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    public int Damage => _damage;
    public float Speed => _speed;
}

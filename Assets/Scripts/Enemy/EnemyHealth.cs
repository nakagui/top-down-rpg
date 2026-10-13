using UnityEngine;

public class EnemyHealth :
    MonoBehaviour,
    IDamageable
{
    [SerializeField] private EnemyData _enemyData;
    private float _hp;

    private void Awake()
    {
        _hp = _enemyData.MaxHP;
    }
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            return;
        }

        _hp -= damage;
        _hp = Mathf.Clamp(_hp, 0, _enemyData.MaxHP);

        if (_hp == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}

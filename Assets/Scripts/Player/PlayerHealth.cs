using UnityEngine;

public class PlayerHealth :
    MonoBehaviour,
    IDamageable
{
    [SerializeField] private int _maxHP = 10;
    [SerializeField] private int _hp;

    private void Awake()
    {
        _hp = _maxHP;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            return;
        }

        _hp -= damage;
        _hp = Mathf.Clamp(
            _hp,
            0,
            _maxHP
        );

        if (_hp == 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Die");
    }
}

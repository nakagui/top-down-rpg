using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth :
    MonoBehaviour,
    IDamageable
{
    [SerializeField] private float _maxHP = 10f;
    [SerializeField] private float _hp;

    [Header("UI")]
    [SerializeField] private Image _hpBar;

    private void Awake()
    {
        _hp = _maxHP;
    }

    public void TakeDamage(float damage)
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
        UpdateLifeBar();

        if (_hp == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Die");
    }

    private void UpdateLifeBar()
    {
        float lifePercentage = _hp / _maxHP;

        _hpBar.fillAmount = lifePercentage;
    }
}

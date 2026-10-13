using UnityEngine;

public class ProjectileDamage : MonoBehaviour
{
    private float _damage;

    private void Start()
    {
        Destroy(gameObject, 1f);
    }

    public void Initialize(float damage)
    {
        _damage = damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<IDamageable>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}

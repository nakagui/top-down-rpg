using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private float _attackForce = 10f;
    [SerializeField] private float _damage = 1f;
    private PlayerInputHandler _input;

    private void Awake()
    {
        _input = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        if (_input.AttackPressed)
        {
            Attack();
            _input.ConsumeAttack();
        }
    }

    private void Attack()
    {
        Vector2 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mousePosition = new(
            mouseScreenPosition.x,
            mouseScreenPosition.y,
            Mathf.Abs(transform.position.z - Camera.main.transform.position.z)
        );
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(
            mouseWorldPosition.x - transform.position.x,
            mouseWorldPosition.y - transform.position.y
        ).normalized;
        GameObject projectileInstance = Instantiate(
            _projectilePrefab,
            transform.position,
            Quaternion.identity
        );
        ProjectileDamage projectileDamage = projectileInstance.GetComponent<ProjectileDamage>();
        projectileDamage.Initialize(_damage);
        Rigidbody2D rigidbody = projectileInstance.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(direction * _attackForce, ForceMode2D.Impulse);
    }
}

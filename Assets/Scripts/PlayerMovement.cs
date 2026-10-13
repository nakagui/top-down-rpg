using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Vector2 _moveInput;
    private Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidBody.linearVelocity = _moveInput * _speed;
    }

    private void OnMove(InputValue value)
    {
        _moveInput = value.Get<Vector2>().normalized;
    }
}

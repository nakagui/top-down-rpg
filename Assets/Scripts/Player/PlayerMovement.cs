using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInputHandler))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Rigidbody2D _rigidBody;
    private PlayerInputHandler _input;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _input = GetComponent<PlayerInputHandler>();
    }

    private void FixedUpdate()
    {
        _rigidBody.linearVelocity = _input.MoveInput * _speed;
    }
}

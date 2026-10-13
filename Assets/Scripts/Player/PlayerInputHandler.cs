using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }
    public bool AttackPressed { get; private set; }

    private void OnMove(InputValue value)
    {
        MoveInput = value.Get<Vector2>().normalized;
    }

    private void OnAttack()
    {
        AttackPressed = true;
    }

    public void ConsumeAttack()
    {
        AttackPressed = false;
    }
}

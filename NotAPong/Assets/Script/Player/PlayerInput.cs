using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{

    public float moveHorizontal;
    public void PlayerInputAction(InputAction.CallbackContext context)
    {
        Vector2 playerInputMove = context.ReadValue<Vector2>();

        moveHorizontal = playerInputMove.y;
    }

}

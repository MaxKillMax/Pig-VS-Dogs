using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private FloatingJoystick Joystick;
    [SerializeField] private Rigidbody2D PlayerRigidbody;

    [Header("Vars")]
    [SerializeField] private float Speed;

    private void Update()
    {
        float InputX = 0;
        float InputY = 0;

        if (Joystick.Horizontal > 0.2f || Joystick.Horizontal < -0.2f)
        {
            InputX = Joystick.Horizontal * Speed;
        }

        if (Joystick.Vertical > 0.2f || Joystick.Vertical < -0.2f)
        {
            InputY = Joystick.Vertical * Speed;
        }

        PlayerRigidbody.velocity = new Vector2(InputX, InputY);
    }
}

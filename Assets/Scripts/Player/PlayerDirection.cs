using UnityEngine;

public class PlayerDirection : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D PlayerRigidbody;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] Sprites;

    [HideInInspector] public string Direction;

    private void Start()
    {
        CheckDirection();
    }

    private void LateUpdate()
    {
        if (PlayerRigidbody.velocity.x != 0 || PlayerRigidbody.velocity.y != 0)
        {
            CheckDirection();
        }
    }

    public void CheckDirection()
    {
        if (Mathf.Abs(PlayerRigidbody.velocity.x) >= Mathf.Abs(PlayerRigidbody.velocity.y))
        {
            if (PlayerRigidbody.velocity.x >= 0)
            {
                spriteRenderer.sprite = Sprites[0];
                Direction = "Right";
            }
            else
            {
                spriteRenderer.sprite = Sprites[1];
                Direction = "Left";
            }
        }
        else
        {
            if (PlayerRigidbody.velocity.y >= 0)
            {
                spriteRenderer.sprite = Sprites[3];
                Direction = "Up";
            }
            else
            {
                spriteRenderer.sprite = Sprites[2];
                Direction = "Down";
            }
        }
    }
}

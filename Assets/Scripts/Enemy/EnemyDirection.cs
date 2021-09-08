using UnityEngine;

public class EnemyDirection : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Transform Target;
    [SerializeField] private Rigidbody2D EnemyRigidbody;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] Sprites;

    [HideInInspector] public string Direction;
    [HideInInspector] public int PriorityDirection01;
    [HideInInspector] public int PriorityDirection23;

    // Defines the dog's sprite (where he is looking) and determines the priority direction for movement
    private void LateUpdate()
    {
        if (Target.position.x > transform.position.x)
        {
            PriorityDirection01 = 0;
        }
        else
        {
            PriorityDirection01 = 1;
        }

        if (Target.position.y > transform.position.y)
        {
            PriorityDirection23 = 2;
        }
        else
        {
            PriorityDirection23 = 3;
        }

        if (EnemyRigidbody.velocity.x != 0 || EnemyRigidbody.velocity.y != 0)
        {
            if (Mathf.Abs(EnemyRigidbody.velocity.x) >= Mathf.Abs(EnemyRigidbody.velocity.y))
            {
                if (EnemyRigidbody.velocity.x >= 0)
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
                if (EnemyRigidbody.velocity.y >= 0)
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
}

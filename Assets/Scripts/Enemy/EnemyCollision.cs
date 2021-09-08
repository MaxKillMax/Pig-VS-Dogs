using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Attack
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<PlayerDeath>().DestroyPig();
        }
    }
}

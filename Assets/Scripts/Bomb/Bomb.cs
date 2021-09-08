using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<PlayerDeath>().DestroyPig();
            DestroyBomb();
        }
        else if (collision.transform.tag == "Enemy")
        {
            collision.transform.GetComponent<EnemyHealth>().GetDamage();
            DestroyBomb();
        }
    }

    private void DestroyBomb()
    {
        AudioSource audioSource = GetComponentInParent<AudioSource>();
        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.volume = Random.Range(0.8f, 1.0f);
        audioSource.Play();

        Destroy(gameObject);
    }
}

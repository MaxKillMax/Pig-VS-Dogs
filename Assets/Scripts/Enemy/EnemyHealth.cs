using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private ChangeHealth changeHealth;

    public float MaxHealth { get; private set; }
    public float CurrentHealth { get; private set; }

    private void Start()
    {
        // Here you can change the maximum health
        MaxHealth = 2;
        CurrentHealth = MaxHealth;
    }

    public void RestoreAllHealth()
    {
        CurrentHealth = MaxHealth;
    }

    public void GetDamage()
    {
        CurrentHealth--;
        changeHealth.GetDamage();

        if (CurrentHealth == 0)
        {
            gameObject.SetActive(false);
        }
    }
}

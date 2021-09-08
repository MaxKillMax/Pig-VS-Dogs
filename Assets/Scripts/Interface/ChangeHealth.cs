using UnityEngine;
using UnityEngine.UI;

public class ChangeHealth : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Complexity complexity;
    [SerializeField] private EnemyFolder enemyFolder;
    [SerializeField] private Image HealthUI;

    private EnemyHealth[] EnemyHealths;

    private void Start()
    {
        EnemyHealths = new EnemyHealth[enemyFolder.Dogs.Length];
        for (int i = 0; i < enemyFolder.Dogs.Length; i++)
        {
            EnemyHealths[i] = enemyFolder.Dogs[i].GetComponent<EnemyHealth>();
        }
    }

    // Responsible for changing the health of all dogs (health bar on top)
    public void GetDamage()
    {
        float CurrentHealth = 0;
        float MaxHealth = 0;

        for (int i = 0; i < enemyFolder.CountOfDogs; i++)
        {
            CurrentHealth += EnemyHealths[i].CurrentHealth;
            MaxHealth += EnemyHealths[i].MaxHealth;
        }

        HealthUI.fillAmount = CurrentHealth / MaxHealth;
        if (CurrentHealth / MaxHealth <= 0)
        {
            complexity.NextComplexity();
            HealthUI.fillAmount = 1;
        }
    }
}

using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject GameUI;
    [SerializeField] private GameObject DeathUI;
    [SerializeField] private GameObject Player;

    public void DestroyPig()
    {
        Time.timeScale = 0;
        Player.SetActive(false);

        GameUI.SetActive(false);
        DeathUI.SetActive(true);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class PlayerBomb : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private PlayerDirection playerDirection;
    [SerializeField] private PlayerBomb playerBomb;

    [SerializeField] private Transform BombFolder;
    [SerializeField] private GameObject BombPrefab;

    [SerializeField] private Image CooldownFiller;
    [SerializeField] private Text CooldownText;

    public float Timer { get; private set; }

    // Throws a bomb in front of him
    private void Update()
    {
        Timer -= Time.deltaTime;

        CooldownFiller.fillAmount = Timer / 5;
        CooldownText.text = Timer.ToString("N1");

        if (Timer <= 0)
        {
            playerBomb.enabled = false;

            CooldownFiller.fillAmount = 0;
            CooldownText.text = "";
        }
    }

    public void SetBomb()
    {
        if (Timer <= 0)
        {
            playerBomb.enabled = true;
            Timer = 5;

            CooldownFiller.fillAmount = 1;
            CooldownText.text = "5";

            GameObject Bomb;
            Bomb = Instantiate(BombPrefab);
            Bomb.transform.parent = BombFolder;

            // I understand that for a better look, this can be replaced, as in the "EnemyMove" method with an array of vectors,
            // but for now I will manage with this scheme
            switch (playerDirection.Direction)
            {
                case "Right":
                    Bomb.transform.position = new Vector3(transform.position.x + 1, transform.position.y, 0);
                    break;
                case "Left":
                    Bomb.transform.position = new Vector3(transform.position.x - 1, transform.position.y, 0);
                    break;
                case "Up":
                    Bomb.transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
                    break;
                case "Down":
                    Bomb.transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
                    break;
            }
        }
    }
}

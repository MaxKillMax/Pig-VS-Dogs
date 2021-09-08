using UnityEngine;
using UnityEngine.UI;

public class Complexity : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject Player;
    [SerializeField] private BombFolder bombFolder;
    [SerializeField] private EnemyFolder enemyFolder;
    [SerializeField] private Text ComplexityLevel;

    private int Level = 0;

    // Killing each dog starts the next level

    // The reloading of bombs is not specially removed, since, logically, the following dogs come to the pig instantly
    public void NextComplexity()
    {
        if (Level == 0)
        {
            Level++;
            ComplexityLevel.text = "Easy";
            enemyFolder.CountOfDogs = 2;
        }
        else if (Level == 1)
        {
            Level++;
            ComplexityLevel.text = "Normal";
            enemyFolder.CountOfDogs = 3;
        }
        else if (Level == 2)
        {
            Level++;
            ComplexityLevel.text = "Hard";
            enemyFolder.CountOfDogs = 4;
        }

        FinalActivate();
    }

    private void FinalActivate()
    {
        Player.transform.position = new Vector3(0, -0.4f, 0);

        bombFolder.ClearAllBombs();
        enemyFolder.SetActive();
    }
}

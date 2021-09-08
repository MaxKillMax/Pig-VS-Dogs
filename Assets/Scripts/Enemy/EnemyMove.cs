using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D EnemyRigidbody;
    [SerializeField] private EnemyDirection enemyDirection;
    [SerializeField] private AcceptedTurn[] AcceptedTurns;

    private float[,] Speed = new float[2, 4]
    {
        { 1.8f, -1.8f, 0, 0 }, // X move
        { 0, 0, 1.8f, -1.8f } // Y move
    };

    private float Timer;
    private int Direction = 1;

    void Update()
    {
        // Moves towards the pig
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Timer = 0.5f;
            Direction = Random.Range(0, 2);

            if (Direction == 0)
            {
                Direction = enemyDirection.PriorityDirection01;
            }
            else
            {
                Direction = enemyDirection.PriorityDirection23;
            }

        }

        // If he finds a pig in the line of sight, he will start walking towards it.
        for (int i = 0; i < AcceptedTurns.Length; i++)
        {
            if (AcceptedTurns[i].Priority && AcceptedTurns[i].Accept)
            {
                Direction = i;
                break;
            }
        }

        EnemyRigidbody.velocity = new Vector2(Speed[0, Direction], Speed[1, Direction]);
    }
}

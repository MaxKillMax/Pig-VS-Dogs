using UnityEngine;

public class AcceptedTurn : MonoBehaviour
{
    public bool Accept { get; private set; }
    public bool Priority { get; private set; }

    private void Start()
    {
        Accept = true;
    }

    // This is the earlier used pig-finding logic. Now this is only used with line of sight.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Stone")
        {
            Accept = false;
        }
        else if (collision.transform.tag == "Player")
        {
            Priority = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Stone")
        {
            Accept = true;
        }
        else if (collision.transform.tag == "Player")
        {
            Priority = false;
        }
    }
}

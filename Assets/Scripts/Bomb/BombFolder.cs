using UnityEngine;

public class BombFolder : MonoBehaviour
{
    public void ClearAllBombs()
    {
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
}

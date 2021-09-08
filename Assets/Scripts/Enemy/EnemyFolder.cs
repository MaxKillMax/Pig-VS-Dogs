using UnityEngine;

public class EnemyFolder : MonoBehaviour
{
    [HideInInspector] public int CountOfDogs = 1;
    [HideInInspector] public GameObject[] Dogs;

    [Header("Components")]
    [SerializeField] private Vector3[] Positions;

    private void Awake()
    {
        Dogs = new GameObject[transform.childCount];
        for (int i = 0; i < Dogs.Length; i++)
        {
            Dogs[i] = transform.GetChild(i).gameObject;
        }
    }

    public void SetActive()
    {
        for (int i = 0; i < Dogs.Length; i++)
        {
            if (i < CountOfDogs)
            {
                Dogs[i].SetActive(true);
                Dogs[i].GetComponent<EnemyHealth>().RestoreAllHealth();
                Dogs[i].transform.position = Positions[i];
            }
            else
            {
                Dogs[i].SetActive(false);
            }
        }
    }
}

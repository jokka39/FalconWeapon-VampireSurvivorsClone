using UnityEngine;

public class MarchSpawnerComponent : MonoBehaviour
{
    // ������ ��� �������� ������� �������� ��������
    public Vector3[] childPositions;
    // ������ �� prefab �����, ������� ����� spawn���
    public GameObject enemyPrefab;
    void Start()
    {
        int childCount = transform.childCount;
        childPositions = new Vector3[childCount];

        for (int i = 0; i < childCount; i++)
        {
            childPositions[i] = transform.GetChild(i).position;
        }
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        if (enemyPrefab == null)
        {
            Debug.LogError("Enemy Prefab not assigned!");
            return;
        }

        foreach (Vector3 pos in childPositions)
        {
            Instantiate(enemyPrefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "wave Config", fileName = "New Wave Config")]
public class WaveConfigSO : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;

    public int GetEnemyCount()
    {
        return enemyPrefabs.Count;
    }

    public Transform GetStartingWaypoint()
    {
        return pathPrefab.GetChild(0);
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }

    public List<Transform> GetWaypoints()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach(Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
}

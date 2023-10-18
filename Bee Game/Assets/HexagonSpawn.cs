using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HexagonSpawn : MonoBehaviour
{

    public GameObject thisHexagon;
    public List<Transform> spawnPoints = new List<Transform>();

    void Start()
    {
        thisHexagon = this.gameObject;

        foreach (Transform child in transform)
        {
            spawnPoints.Add(child);
        }


    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Building");
            EnableSpawnPoints();

        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("Cancel");
            DisableSpawnPoints();

        }
    }

    private void EnableSpawnPoints()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            spawnPoint.gameObject.SetActive(true);
        }
    }

    public void DisableSpawnPoints()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            spawnPoint.gameObject.SetActive(false);
        }
        Debug.Log("disablaling spawn points");
    }
}

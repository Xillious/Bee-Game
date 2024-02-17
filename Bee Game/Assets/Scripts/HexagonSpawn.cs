using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HexagonSpawn : MonoBehaviour
{

    public GameObject thisHexagon;
    public List<Transform> spawnPoints = new List<Transform>();

    public GameMaster gameMaster;

    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
    }

    void Start()
    {
        thisHexagon = this.gameObject;

        foreach (Transform child in transform)
        {
            //adds each spawn point around the hexagon to a list
            spawnPoints.Add(child);
        }

        DisableSpawnPoints();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //allows you to place new hexagons
            Debug.Log("Building");
            gameMaster.SwitchState(GameMaster.GameState.Building);

        }
        if (gameMaster.currentState == GameMaster.GameState.Building)
        {
            EnableSpawnPoints();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            gameMaster.SwitchState(GameMaster.GameState.NotBuilding);
            DisableSpawnPoints();
        }


    }

    private void EnableSpawnPoints()
    {
        //enables spawn points around the hexagon
        foreach (Transform spawnPoint in spawnPoints)
        {
            spawnPoint.gameObject.SetActive(true);
        }
    }

    public void DisableSpawnPoints()
    {
        //disables spawn points around the hexagon
        foreach (Transform spawnPoint in spawnPoints)
        {
            spawnPoint.gameObject.SetActive(false);
        }
        Debug.Log("disablaling spawn points");
    }


}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HexagonSpawn : MonoBehaviour
{

    public GameObject thisHexagon;
    public List<Transform> spawnPoints = new List<Transform>();

    public GameMaster gameMaster;
    public RectTransform hexagonMenu;
    public GameObject hexagonMenuGameObject;
    public GameObject gameMasterGameObject;

    public int resourceCost;

    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
        gameMasterGameObject = GameObject.FindGameObjectWithTag("GameMaster");
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

        if (gameMaster.currentState == GameMaster.GameState.Building)
        {
            EnableSpawnPoints();
        }

        if (gameMaster.currentState != GameMaster.GameState.Building)
        {
            DisableSpawnPoints();
        }



    }

    private void OnMouseDown()
    {
        gameMaster.OpenMenu(hexagonMenu);
        Debug.Log("open menu");
        //this.gameObject.SetActive(false);
        //hexagonMenuGameObject.SetActive(true);
    }

    /*
        private void OnMouseDown(GameObject hexagon)
        {
            //gameMaster.selectedHexagon = this.gameObject;
            //gameMaster.OpenMenu(gameMaster.selectedHexagon);
            //Debug.Log("open menu");
        }
    */
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
    }

    public void HexagonToSpawn(GameObject hexagon)
    {

    }


}

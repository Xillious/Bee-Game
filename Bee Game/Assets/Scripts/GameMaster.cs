using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameMaster : MonoBehaviour
{

    public enum GameState
    {
        Playing,
        Building,
        NotBuilding
    }

    public GameState currentState;

    public RectTransform buildMenu;
    public RectTransform redHexagonMenu;

    public GameObject redHexagon;
    public GameObject blueHexagon;
    public GameObject selectedSpawnPoint;
    //public GameObject selectedHexagon;

    public int resources;

    private bool hasEnoughResources = false;

    void Start()
    {
        currentState = GameState.Playing;
        //Debug.Log("Game state is: " + currentState);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Debug.Log("Game state is: " + currentState);
            //SwitchState(GameState.Building);
            resources = resources + 10;
        }
        //Debug.Log(hasEnoughResources);

        if (Input.GetKeyDown(KeyCode.B))
        {

            SwitchState(GameState.Building);

        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchState(GameState.NotBuilding);
            //DisableSpawnPoints();
        }


    }

    public void SwitchState(GameState newState)
    {
        currentState = newState;
        //Debug.Log("Game state is: " + currentState);
    }

    GameState GetCurrentState()
    {
        return currentState;
    }

    public void OpenMenu(RectTransform menu)
    {
        menu.gameObject.SetActive(true);
        Debug.Log("open menu" + menu);

    }

    public void CloseMenu(RectTransform menu)
    {
        menu.gameObject.SetActive(false);
    }

    public void CreateHexagon(GameObject newHexagon)
    {
        //takes input of the hexagon to create then creates it at the position

        CheckResourceCost(10);
        if (hasEnoughResources == true)
        {
            Instantiate(newHexagon, selectedSpawnPoint.transform.position, selectedSpawnPoint.transform.rotation);
        }
        else
        {
            Debug.Log("not enough resources");
        }


        //hexagonSpawn.DisableSpawnPoints();
    }

    public void CheckResourceCost(int resourceCost)
    {
        if (resourceCost <= resources)
        {
            hasEnoughResources = false;
        }

        if (resourceCost >= resources)
        {
            hasEnoughResources = true;
        }
    }


}

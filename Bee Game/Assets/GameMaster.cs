using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public enum GameState
    {
        Playing,
        Building,
        NotBuilding
    }

    public GameState currentState;

    public Canvas buildMenu;

    public GameObject redHexagon;
    public GameObject blueHexagon;

    public GameObject selectedSpawnPoint;

    void Start()
    {
        currentState = GameState.Playing;
        Debug.Log("Game state is: " + currentState);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Game state is: " + currentState);
            //SwitchState(GameState.Building);

        }
    }

    public void SwitchState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Game state is: " + currentState);
    }

    GameState GetCurrentState()
    {
        return currentState;
    }

    public void OpenMenu(Canvas menu)
    {
        menu.gameObject.SetActive(true);
    }

    public void CloseMenu(Canvas menu)
    {
        menu.gameObject.SetActive(false);
    }

    public void CreateHexagon(GameObject newHexagon)
    {
        //takes input of the hexagon to create then creates it at the position
        Instantiate(newHexagon, selectedSpawnPoint.transform.position, selectedSpawnPoint.transform.rotation);
        //hexagonSpawn.DisableSpawnPoints();
    }


}

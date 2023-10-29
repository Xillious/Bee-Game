using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

    public enum GameState
    {
        Playing,
        Building
    }

    public GameState currentState;

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
}

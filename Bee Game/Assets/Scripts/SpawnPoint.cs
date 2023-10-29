using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class SpawnPoint : HexagonSpawn
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    private HexagonSpawn hexagonSpawn;
    public GameObject hexagon;
    //public GameMaster gameMaster;

    public bool objectInSpace = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
        hexagonSpawn = GetComponentInParent<HexagonSpawn>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        Highlight();
    }

    private void OnMouseExit()
    {
        UnHighlight();
    }

    private void OnMouseDown()
    {
        UnHighlight();
        CreateHexagon(hexagon);
    }

    private void Highlight()
    {
        //highlights the hovered hexagon if in build state
        if (gameMaster.currentState == GameMaster.GameState.Building)
        {
            spriteRenderer.enabled = true;
        }
    }

    private void UnHighlight()
    {
        //unhilights the hovered tile if the cursor moves out of it
        spriteRenderer.enabled = false;
    }

    private void CreateHexagon(GameObject newHexagon)
    {
        //takes input of the hexagon to create then creates it at the position
        Instantiate(newHexagon, this.transform.position, this.transform.rotation);
    }

}

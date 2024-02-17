using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class SpawnPoint : HexagonSpawn
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    private HexagonSpawn hexagonSpawn;
    public GameObject hexagon;
    public GameObject selectedSpawnPoint;


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
        SelectSpawnPoint();
        //CreateHexagon(hexagon);
        hexagonSpawn.DisableSpawnPoints();
        gameMaster.OpenMenu(gameMaster.buildMenu);
    }

    private void Highlight()
    {
        //highlights the hovered hexagon if in build state
        spriteRenderer.enabled = true;
    }

    private void UnHighlight()
    {
        //unhilights the hovered tile if the cursor moves out of it
        spriteRenderer.enabled = false;

    }

    private void CreateHexagon(GameObject newHexagon)
    {
        /*
        //takes input of the hexagon to create then creates it at the position
        Instantiate(newHexagon, this.transform.position, this.transform.rotation);
        hexagonSpawn.DisableSpawnPoints();
        */

        //oeens the build menu
        gameMaster.OpenMenu(gameMaster.buildMenu);

        //Instantiate(newHexagon, this.transform.position, this.transform.rotation);
        hexagonSpawn.DisableSpawnPoints();
    }

    public void SelectSpawnPoint()
    {
        gameMaster.selectedSpawnPoint = this.gameObject;
        //selectedSpawnPoint = this.gameObject;

    }



}

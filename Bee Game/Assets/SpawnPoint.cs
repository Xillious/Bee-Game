using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : HexagonSpawn
{
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    public HexagonSpawn hexagonSpawn;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
        hexagonSpawn = GetComponent<HexagonSpawn>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        Color newColour = spriteRenderer.color;
        newColour.a = 1f;
        spriteRenderer.color = newColour;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = originalColor;
    }

    private void OnMouseDown()
    {
        hexagonSpawn.DisableSpawnPoints();
    }
}

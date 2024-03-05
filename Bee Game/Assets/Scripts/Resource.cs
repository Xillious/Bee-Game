using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour
{

    //public Text resourceText;
    public GameMaster gameMaster;

    public TextMeshProUGUI resourceText;

    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
    }

    void Start()
    {

    }


    void Update()
    {
        resourceText.text = gameMaster.resources.ToString();
    }
}

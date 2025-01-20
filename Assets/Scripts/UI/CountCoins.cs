using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountCoins : MonoBehaviour
{

    public Platformer.Mechanics.PlayerController player; 
    public TextMeshProUGUI number;

    // Start is called before the first frame update
    void Start()
    {
        number = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        string text = player.coinsCollected.ToString();
        if (text.Length < 2) text = "0" + text;
        number.text = text;     
    }
}

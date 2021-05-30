using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_script : MonoBehaviour
{
    public TextMeshProUGUI player_name;
    Tutorial_script tutorial;
    public Data_scriptableObject player_name_data;
    // Start is called before the first frame update
    void Start()
    {
        player_name.text = "Player: " + player_name_data.data_string;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

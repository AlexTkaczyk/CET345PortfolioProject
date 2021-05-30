using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Tutorial_script : MonoBehaviour
{

    public TMP_InputField player_name_input;
    public Data_scriptableObject player_name_data;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Start_Game()
    {
        Debug.Log("Player: " + player_name_input.text);
        player_name_data.data_string = player_name_input.text;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

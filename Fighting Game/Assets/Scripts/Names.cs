using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names : MonoBehaviour
{
    public static string Player1Name, Player2Name;

    public void readP1NameInput(string name){
        Player1Name = name;
        Debug.Log(Player1Name);
    }
    public void readP2NameInput(string name){
        Player2Name = name;
        Debug.Log(Player2Name);
    }

}

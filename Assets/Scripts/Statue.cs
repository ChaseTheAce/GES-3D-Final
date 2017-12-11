using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statue : MonoBehaviour, IActivatable {
    [SerializeField]
    private string nameText;


    WinGame winGame;

    

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    public void DoActivate()
    {
        winGame.CheckForWin();
    }


    void Start ()
    {
        winGame = GetComponent<WinGame>();
	}
	
}

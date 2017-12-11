using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {
    private List<InventoryObject> playerInventory;


    [SerializeField]
    InventoryObject orb1;
    [SerializeField]
    InventoryObject orb2;
    [SerializeField]
    InventoryObject orb3;
    

    private bool HasWinCondition
    {
        get
        {
            return playerInventory.Contains(orb1) && playerInventory.Contains(orb2) && playerInventory.Contains(orb3);
        }

    }

    private void Start()
    {
        playerInventory = FindObjectOfType<InventoryMenu>().PlayerInventory;
    }


    void GotToWinScreen()
    {
        SceneManager.LoadScene("Win Screen");
    }

    public void CheckForWin()
    {
        if (HasWinCondition == true)
        {
            GotToWinScreen();
        }
    }
    
}

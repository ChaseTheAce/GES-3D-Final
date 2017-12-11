using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour {

    public void StartButtonClicked()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("Credits Scene");
    }
}

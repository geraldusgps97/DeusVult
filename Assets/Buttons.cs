using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public void GoToWorld()
    {
        SceneManager.LoadScene("World");
    }

    public void GoToWorldWin()
    {
        SceneManager.LoadScene("World");
        GameManager.Instance.CurrentPlayer.AddXp(20);
        Debug.Log("success!");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

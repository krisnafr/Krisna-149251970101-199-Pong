using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GoCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Me()
    {
        Debug.Log("Created by Krisna F R - 149251970101-199");
    }
}

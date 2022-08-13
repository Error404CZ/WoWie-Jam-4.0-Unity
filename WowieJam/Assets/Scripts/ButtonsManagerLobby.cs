using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManagerLobby : MonoBehaviour
{
    [SerializeField] private List<GameObject> menus = new List<GameObject>();

    public void Start()
    {
        foreach (var x in menus)
        {
            x.SetActive(false);
        }
        menus[0].SetActive(true);
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void CreditsButton()
    {
        foreach (var x in menus)
        {
            x.SetActive(false);
        }
        menus[1].SetActive(true);
    }
    
    public void BackButton()
    {
        foreach (var x in menus)
        {
            x.SetActive(false);
        }
        menus[0].SetActive(true);
    }
    
    public void ExitGameButton()
    {
        Application.Quit();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagerGame : MonoBehaviour
{
    [SerializeField] private List<GameObject> menus = new List<GameObject>();
    
    [SerializeField] private TextMeshProUGUI flagCount;
    public FlagController flagController;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
        menus[0].SetActive(true);
    }

    private void Update()
    {
        flagCount.text = "Flags: " + flagController.flagCount;
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            foreach (GameObject menu in menus)
            {
                menu.SetActive(false);
            }
            menus[1].SetActive(true);
        }
    }

    public void LobbyButton()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void BackButtton()
    {
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
        menus[0].SetActive(true);
    }
}

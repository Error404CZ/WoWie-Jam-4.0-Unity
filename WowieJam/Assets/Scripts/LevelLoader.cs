using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    [SerializeField] private string levelToLoad;
    public void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}

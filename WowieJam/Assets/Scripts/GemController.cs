using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    public FlagController flagController;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            flagController.flagCount++;
            Destroy(gameObject);
        }
    }
}

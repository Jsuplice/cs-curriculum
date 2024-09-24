using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameManager GameManager;
    void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
        if(GameManager == null)
            Debug.Log("Gamemanager was not found in scene");
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == ("Spikes"))
        {
            GameManager.ChangeHealth(-1);
            print("took damage");
        }
    }
}

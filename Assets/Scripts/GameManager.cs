using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Gm ;
    private int Health;
    public int MaxHealth = 10;
    
    public void Awake()
    {
        if (Gm != null && Gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Die()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeHealth(int amount)
    {
        Health += amount;
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        if (Health < 1)
        {
            Die();
        }
    }
    

}

    

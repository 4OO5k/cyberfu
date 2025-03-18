using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxPlayerHealth = 10;
    public int currentPlayerHealth;
    public int enemyDamage = 2;
   
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }

    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
    }
    
}

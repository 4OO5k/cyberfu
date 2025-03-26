using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxPlayerHealth = 10;
    public int currentPlayerHealth;
    public int enemyDamage = 2;

    private Animator playerAnimator;
    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;

        playerAnimator = GetComponent<Animator>();
    }

    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
        playerAnimator.SetTrigger("Hit");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HitCollider"))
        {
            HurtPlayer();
        }
    }
    
}

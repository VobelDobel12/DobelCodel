using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private int health = 10;
    private int coins = 0;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);

        if (health <= 0){
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }
    }
    public void CollectCoins(){
        coins++;
        print("Собранные монетки:" + coins);
    }
}

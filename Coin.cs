using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        PlayerScript player = other.GetComponent<PlayerScript>();
        player.CollectCoins();
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        //Меняет каждый кадр позицию NPC на новую 
     	    
    transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
 
        //Разворачивает каждый кадр NPC лицом к цели
     	    
        transform.LookAt(target.position);
    }
    private void OnTriggerEnter(Collider other) {
        PlayerScript player = other.GetComponent<PlayerScript>();
        player.TakeDamage(playerDamage);
    }
}

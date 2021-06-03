using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 0;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Acid")){
            Destroy(other.gameObject);
            
            if (health == 0){
                Destroy(gameObject);
            } else if (health >= 0){
                health -= 1;
            }
        }
    }
}

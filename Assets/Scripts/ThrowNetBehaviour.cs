using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ThrowNetBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Wall") {
            Destroy(gameObject);
        }
    }
}

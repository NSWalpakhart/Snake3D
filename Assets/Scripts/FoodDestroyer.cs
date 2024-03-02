using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SnakeHead"))
        {
            other.GetComponent<SnakeMovementController>().AddTailPart();
            Destroy(gameObject);
        }
    }
}

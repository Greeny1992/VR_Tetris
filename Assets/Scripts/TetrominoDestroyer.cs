using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrominoDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Plane")
        {
            Debug.Log("Collision Triggered");
            GameObject go = GameObject.FindWithTag("Respawn");
            TetrominoSpawner spawner = go.GetComponent<TetrominoSpawner>();
            spawner.SpawnTetromino();
            Destroy(gameObject);
        }
        
    }
}

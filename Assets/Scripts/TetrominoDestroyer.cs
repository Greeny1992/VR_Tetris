using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrominoDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.FindWithTag("Respawn");
        TetrominoSpawner spawner = go.GetComponent<TetrominoSpawner>();
        if(other.transform.gameObject.tag != "SnapPlane")
        {
            if (other.transform.gameObject.tag == "Table")
            {
                TetrominoMoveConstantlyDown mover = gameObject.GetComponent<TetrominoMoveConstantlyDown>();
                mover.enabled = true;
                mover.usePhysics = true;
                spawner.SpawnTetromino();
                this.enabled = false;
            }
            else if(other.transform.gameObject.tag == "Plane")
            {
                Debug.Log("Collision Triggered Plane");
                spawner.SpawnTetromino();
                Destroy(gameObject);

            }
        }

    }
}

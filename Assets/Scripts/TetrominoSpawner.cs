using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrominoSpawner : MonoBehaviour
{
    public GameObject[] tetrominos;
    // Start is called before the first frame update

    void Start()
    {
        SpawnTetromino();
    }

    public void SpawnTetromino()
    {
        Debug.LogWarning("Spawner");
        Vector3 left = new Vector3(-1, 2, -0.5f);
        Vector3 right = new Vector3(1, 2, -0.5f);
        Vector3 behind = new Vector3(0, 2, -1);
        Vector3[] spawnPositions = new Vector3[] { left, right, behind };
        System.Random random = new System.Random();
        int randomTetromino = random.Next(0, tetrominos.Length);
        int randomPosition = random.Next(0, spawnPositions.Length);
        Quaternion spawnRotation = new Quaternion();
        if (randomPosition  == 0|| randomPosition == 1)
        {
            spawnRotation = Quaternion.Euler(0, 90, 0);
        }
        Instantiate(tetrominos[randomTetromino], spawnPositions[randomPosition], spawnRotation);
    }
}

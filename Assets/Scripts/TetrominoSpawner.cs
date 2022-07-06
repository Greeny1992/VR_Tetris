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
        Vector3 left = new Vector3(-1, 5, -0.5f);
        Vector3 right = new Vector3(1, 5, -0.5f);
        Vector3 behind = new Vector3(-2, 5, -1);
        Vector3[] spawnPositions = new Vector3[] { left, right, behind };
        System.Random random = new System.Random();
        int randomTetromino = random.Next(0, tetrominos.Length);
        int randomPosition = random.Next(0, spawnPositions.Length);
        Instantiate(tetrominos[randomTetromino], spawnPositions[randomPosition], new Quaternion());
    }
}

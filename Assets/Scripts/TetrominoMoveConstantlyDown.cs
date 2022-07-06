using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TetrominoMoveConstantlyDown : MonoBehaviour
{
    public bool usePhysics = false;
    [SerializeField] private float force = 1f;
    [SerializeField] private float timeInterval = 1f;
    [SerializeField] private float travelDistance = 1f;
    bool enabled = false;

    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if (usePhysics)
        {
            var rb = transform.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.down * force);

            if (rb.useGravity)
                Debug.LogWarning("Tetronimo uses Gravity, despite having an initial Force!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(!enabled)
        {
            if (!usePhysics)
            {
                currentTime += Time.deltaTime;

                if (currentTime >= timeInterval)
                {
                    transform.position += Vector3.down * travelDistance;
                    currentTime = 0f;
                }
            }
        }
        
    }
}

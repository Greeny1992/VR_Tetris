using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TetrominoMoveConstantlyDown : MonoBehaviour
{
    [SerializeField] private bool usePhysics = false;
    [SerializeField] private float force = 1f;
    [SerializeField] private float timeInterval = 1f;
    [SerializeField] private float travelDistance = 1f;

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
        if (!usePhysics)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= timeInterval)
            {
                //Ray ray = new Ray(transform.position, Vector3.down);
                //RaycastHit hit;
                //if (Physics.Raycast(ray, out hit))
                //{
                //    if (hit.distance <= 0.1f)
                //        Destroy(gameObject);
                //    //return;// return; //replace me - hier passiert was wenn wir net weiter runter gehn solln
                //}
                transform.position += Vector3.down * travelDistance;
                currentTime = 0f;
            }
        }
    }
}

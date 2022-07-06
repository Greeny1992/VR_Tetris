using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrominoRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One,OVRInput.Controller.LTouch)) 
        {
            this.transform.Rotate(Vector3.forward, 90.0f);
        }
    }
}

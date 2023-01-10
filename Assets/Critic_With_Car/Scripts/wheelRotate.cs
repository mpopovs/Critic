using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelRotate : MonoBehaviour
{
   
 
    // Update is called once per frame
    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
       // transform.RotateAround(transform.position, Vector3.right, 20 * Time.deltaTime);
        transform.Rotate(0, 0, 60 * Time.deltaTime);
    }
}

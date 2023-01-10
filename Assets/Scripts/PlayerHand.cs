using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float launchVelocity = 700f;
    // Update is called once per frame
    void Update()
    {
        
         // Push by presing space
        if (Input.GetKeyDown(KeyCode.Tab))
        {
          GameObject hand =  Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

             hand.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 
                                                (0, launchVelocity,0));
        }
    }
}

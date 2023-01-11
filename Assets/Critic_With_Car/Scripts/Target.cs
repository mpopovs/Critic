using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    
   [SerializeField]
    private AudioClip _clip;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
         if (collision.gameObject.CompareTag("Player"))
     {
        AudioSource.PlayClipAtPoint(_clip, transform.position);
         Debug.Log("Done");
        GameManager.instance.AddPoints();
       
     }
    
    }
}

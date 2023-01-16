using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayerCamera : MonoBehaviour
{
        public Transform player;
    private Rigidbody playerRB;
    public Vector3 Offset;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerForward = (playerRB.velocity + player.transform.forward).normalized;
        transform.position = Vector3.Lerp(transform.position,
            player.position + player.transform.TransformVector(Offset)
            + playerForward * (-5f),
            speed * Time.deltaTime);
        transform.LookAt(player);
    }

    /*
    public Transform targetPlayer;
    public float pLerp = 0.02f;
    public float rLerp = 0.01f;
   
   private Vector3 offset = new Vector3(0, 2, -15);

    // Start is called before the first frame update
   

    // Update is called once per frame
  void LateUpdate()
    {
        Vector3 relativePos = targetPlayer.position - transform.position;
       // transform.position = player.transform.position + offset;
     transform.position = Vector3.Lerp(transform.position, targetPlayer.position + offset, pLerp );

       transform.rotation = Quaternion.Lerp(transform.rotation , targetPlayer.rotation , rLerp);
       Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
     //  transform.rotation = rotation;
    }
   */
}

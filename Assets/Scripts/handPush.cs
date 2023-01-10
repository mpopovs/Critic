using UnityEngine;
 
public class handPush : MonoBehaviour
{
    Animator anim;
 
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Active");
        }
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    public void OnTriggerEnter()
    {                
            Debug.Log("within reach");
        animator.SetBool("character_nearby", true);
    }
    public void OnTriggerExit()
    {
        Debug.Log("lost connection");
        animator.SetBool("character_nearby", false);
    }

}

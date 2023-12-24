using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator> ();
        animator.SetBool("isJumpJack", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isSitUp", true);
        } 

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isJumpJack", true);
        } 

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isPlank", true);
        } 
    }
}

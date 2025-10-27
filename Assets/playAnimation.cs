using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to play animation
    public void PlayAnimation()
    {
        if (animator != null)
        {
            animator.Play("rack"); // Replace "AnimationName" with the name of your animation
        }
    }
}
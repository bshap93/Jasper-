using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerController : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
            animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Eat();
        Idle();
        
        
    }
    
    public void Eat()
    {
        StartCoroutine(EatCoroutine());
    }

    
    IEnumerator EatCoroutine()
    {
        animator.SetBool("isEating", true);
        yield return new WaitForSeconds(10);


    }
    
    public void Idle()
    {
        StartCoroutine(IdleCoroutine());
    }
    
    IEnumerator IdleCoroutine()
    {
        animator.SetBool("isEating", false);
        yield return new WaitForSeconds(10);
    }
}

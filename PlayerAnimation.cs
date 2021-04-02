using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;
public class PlayerAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    RigidbodyFirstPersonController rigidBody;
    [HideInInspector]
    public bool isAttack;
    void Start()
    {
        animator=GetComponent<Animator>();
        rigidBody=GetComponentInParent<RigidbodyFirstPersonController>();

    }

    // Update is called once per frame

    public void PlayerIdle(){
    	if(rigidBody.runAxis.x==0 && rigidBody.runAxis.y==0){
            if(rigidBody.jumpAxis){
                animator.SetBool("jump",true);
            }
            else{
                animator.SetBool("jump",false);
            }
    		animator.SetBool("run",false);
            if(isAttack){
                animator.SetBool("attack",true);

            }
            else{
                animator.SetBool("attack",false);

            }

    	}
    	else if(isAttack){
    			animator.SetBool("attack",true);
        }
    	
    	else{
            animator.SetBool("run",true);
            if(rigidBody.jumpAxis){
                animator.SetBool("jump",true);
            }
            else{
                animator.SetBool("jump",false);
            }
            if(isAttack){
                animator.SetBool("attack",true);
            }
            else{
                animator.SetBool("attack",false);
            }
    		

    	}
    }


    void Update()
    {
    	PlayerIdle();

    }
}

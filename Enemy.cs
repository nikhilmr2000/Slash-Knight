using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    NavMeshAgent navMeshAgent;
    [SerializeField] Transform target;
    [SerializeField] float rangeOfEnemy=15f;
    void Start()
    {
        navMeshAgent=GetComponent<NavMeshAgent>();
        animator=GetComponent<Animator>();

    }
    

    // Update is called once per frame
    void Update()
    {
    	
        NavigatingMethod();
        
    }

    private void NavigatingMethod(){


    	float distanceToTarget=Vector3.Distance(transform.position,target.position);
        //Debug.Log(distanceToTarget);
    	if(distanceToTarget>rangeOfEnemy){
    		animator.SetBool("idle",true);
            animator.SetBool("walk",false);
    		animator.SetBool("isAttack",false);
            //create no method as nothing has to be done when the player is outside of the enemy range but an idle animation for the enemy has to be set here.
    	}
    	else if(distanceToTarget<=rangeOfEnemy){
    		//do a animation for moving a character towards the enemy
    		
            
            if(distanceToTarget<=2.4){
                animator.SetTrigger("attack");
                animator.SetBool("isAttack",true);
                float singleStep=Time.deltaTime;
                Vector3 targetDirection = target.position - transform.position;
                Vector3 newDirection = Vector3.RotateTowards(transform.forward,targetDirection, singleStep, 0.0f);
                transform.rotation=Quaternion.LookRotation(newDirection);
                // make it to move towards the direction where the player is moving...

            }
            else if(distanceToTarget>navMeshAgent.stoppingDistance){
                animator.SetBool("walk",true);
                animator.SetBool("idle",false);
                animator.SetBool("isAttack",false);
                navMeshAgent.SetDestination(target.position);
            }
    	}


    		
    }
}

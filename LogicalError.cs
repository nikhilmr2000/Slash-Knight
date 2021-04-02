using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalError : MonoBehaviour
{
    // Start is called before the first frame update

    EnemyParticle enemy;
    [SerializeField] Animator animator;
    void Start()
    {
        enemy=FindObjectOfType<EnemyParticle>();
    }

    private void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="Knife"){
    		if(animator.GetBool("attack")==true){
    			Debug.Log("InsideTrigger");
    			enemy.TriggerMaker();
    			Destroy(gameObject);
    		}

    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

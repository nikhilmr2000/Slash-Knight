using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyParticle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float damage=5f;
    PlayerHealth playerHealth;
    //[SerializeField] Animator animator
    public Slider slider;
    Animator animator;
    void Start()
    {
        playerHealth=FindObjectOfType<PlayerHealth>();
        animator=GetComponentInParent<Animator>();
        slider.value=playerHealth.HealthCalculation();
    }

    public void TriggerMaker(){
    	//if(other.gameObject.tag=="Finish"){
    		Debug.Log("Outside");
    		//if(animator.GetBool("attack")==true){
    		playerHealth.hitPoints-=damage;
    		slider.value=playerHealth.HealthCalculation();
    		Debug.Log("Inside " + playerHealth.hitPoints);
    		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

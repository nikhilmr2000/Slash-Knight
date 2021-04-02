using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float energy=50;
    Animator animator;
    void Start()
    {
    	animator=GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="Player"){
    		Debug.Log("Player acquired strength");
    		// method that tells this is a lowPower or HighPower and enhance it with some value of strength.
    		FindObjectOfType<EnergyDifference>().Calculator(energy);
    		Destroy(gameObject,0.01f);
    	}
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerForward : MonoBehaviour{
    // Start is called before the first frame update
    Rigidbody rb;
    RigidbodyFirstPersonController rigidBody;
    private bool isCorrect=true;
    private float speed=5f;

    void Start(){
    	rb=GetComponent<Rigidbody>();
    	rigidBody=GetComponent<RigidbodyFirstPersonController>();
    }


    public void StartDimension(){
    	Vector2 moveForeground=new Vector2(rigidBody.runAxis.x,rigidBody.runAxis.y);
    	if(CrossPlatformInputManager.GetButton("Fire1")){
    		if(moveForeground.magnitude>0){
    		if(isCorrect==true){
    			Debug.Log("Called");
    			rb.AddForce(0,0,moveForeground.y);
    			isCorrect=false;
    		}
    		else{
    			//rigidbody is kept constant
    			rb.AddForce(0,0,0);
    			Debug.Log("Recalled");
    			isCorrect=true;
    		}
    	}

    	}

    }


    void Update(){
    	
    }
    
}

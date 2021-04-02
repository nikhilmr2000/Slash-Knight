using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerSprint : MonoBehaviour
{
    // Start is called before the first frame update
     // [SerializeField] float speedRise=3f;
    //private bool isAlive=true;
    RigidbodyFirstPersonController rigidBody;
    public bool isRun;
   // public bool isPressed;
	private float speed;
    void Start()
    {
        rigidBody=GetComponent<RigidbodyFirstPersonController>();
    } 

    private void Sprinter(){
    	if(isRun){
    		rigidBody.movementSettings.CurrentTargetSpeed=rigidBody.movementSettings.ForwardSpeed+2f;
    	}

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

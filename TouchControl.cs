using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class TouchControl : MonoBehaviour
{
    // Start is called before the first frame update
    public FixedJoystick moveJoystick;
    public FixedButton1 jumpButton;
    public FixedButton1 attackButton;
    //public FixedButton1 runButton; 
    public FixedTouchField touchField;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	var fps=GetComponent<RigidbodyFirstPersonController>();
    	var animator=GetComponentInChildren<PlayerAnimation>();
    	var sprint=GetComponent<PlayerForward>();
    	fps.runAxis=moveJoystick.Direction;
    	fps.jumpAxis=jumpButton.Pressed;
    	animator.isAttack=attackButton.Pressed;
    	//fps.movementSettings.isRun=runButton.Pressed;
        //sprint.pressed=runButton.Pressed;
    	fps.mouseLook.lookAxis=touchField.TouchDist;
        
    }
}

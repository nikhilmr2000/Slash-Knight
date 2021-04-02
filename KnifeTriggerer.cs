using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class KnifeTriggerer : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] public KnifeType type;
    [SerializeField] public GameObject game;
    //[SerializeField] public KnifeExchanger knife;
    private bool isStart;
    void Start()
    {
      
    }

    void OnTriggerEnter(Collider other){
    	if(other.gameObject.tag=="Player"){
    		Debug.Log("Collided but not moved");
    		Debug.Log("Collided");
    		//knife.BigKnife(type,game);
    		//knife.ChangeWhenTriggered(game);
    		SendMessageUpwards("ChangeWhenTriggered",game);
    		Destroy(gameObject);

    	    
    		
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

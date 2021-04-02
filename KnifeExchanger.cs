using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeExchanger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] SmallKnife[] smallKnife;
    private bool isPicked=true;
    [System.Serializable]
    private class SmallKnife{
    	public KnifeType type;
    	public GameObject gameObject;

    }
    void Start()
    {
    }

    public void BigKnife(KnifeType type,GameObject gameObject){
    	if(isPicked==true){
    		Debug.Log("Knife took");
    		Small(type).gameObject.SetActive(true);
    		isPicked=false;
    	}
    	else{
    		Debug.Log("Knife kept");
    		Small(type).gameObject.SetActive(false);
    		isPicked=true;
    	}

    }


    private SmallKnife Small(KnifeType type){
    	foreach(SmallKnife knife in smallKnife){
    		if(knife.type==type){
    			return knife;
    		}
    	}
    	return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

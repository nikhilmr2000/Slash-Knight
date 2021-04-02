using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MapAccess : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Canvas killAliveUI;
    [SerializeField] public Canvas mapUI;
    [SerializeField] public Camera cam;
   // [SerializeField] public GameObject player;
   // [SerializeField] public GameObject enemy;
    public bool isActive=true;
    void Start()
    {
     	mapUI.enabled=false;

    }


    public void KillAlive(){
    	killAliveUI.enabled=true;
    	mapUI.enabled=false;
    	cam.enabled=false;
    	Time.timeScale=1;

    }

    public void MapUI(){
    	killAliveUI.enabled=false;
    	mapUI.enabled=true;
    	cam.enabled=true;
    	Time.timeScale=0;

    }

    // Update is called once per frame
    void Update()
    {

    	/*if(isActive==false){
    		player.enabled=false;
    	    enemy.enabled=false;

    	}*/

        
    }
}

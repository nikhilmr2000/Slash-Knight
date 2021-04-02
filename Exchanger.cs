using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Exchanger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] gameObject;
    [SerializeField] TextMeshProUGUI textUI;
    [SerializeField] GameObject inBuild;
    private bool isFound=true;
    void Start()
    {
        
    }

    private void SetOnlyOne(){
    	foreach(GameObject game in gameObject ){
    		if(game.active){
    			game.SetActive(false);
    		}
    	}
    }

    private void SetRemaining(){
    	foreach(GameObject game in gameObject){
    		if(game.active){
    			game.SetActive(true);
    		}
    	}
    }
    public void ChangeWhenTriggered(GameObject gamer){
    	foreach(GameObject game in gameObject){
    		if(game==gamer){
    			//if(isFound==true){
    				SetOnlyOne();
    				inBuild.SetActive(false);
    				gamer.SetActive(true);
    				textUI.text=gamer.name.ToString();
    				//isFound=false;
    			//}
    			/*else{
    				gamer.SetActive(false);
    				inBuild.SetActive(true);
    				SetRemaining();
    				Debug.Log(gamer.name);
    				textUI.text=gamer.name.ToString();
    				isFound=true;
    			}*/
    			}
    		}
    	
   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

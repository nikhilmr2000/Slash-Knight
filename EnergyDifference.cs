using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDifference : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] public  int[] energy;
    //[SerializeField] public PowerBankType type;
    PlayerHealth player;
    void Start()
    {
        player=FindObjectOfType<PlayerHealth>();
    }

    public void Calculator(float energy){
    	if(player.hitPoints<100){
    		player.hitPoints+=energy;
    		player.slider.value=player.HealthCalculation();
    		if(player.hitPoints>100){
    			player.hitPoints=100;
    		}
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

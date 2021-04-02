using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTypes : MonoBehaviour
{
    // Start is called before the first frame update
    
    PlayerHealth player;
    [SerializeField] EnergyPack[] energy;

    [System.Serializable]
    private class EnergyPack {
    	public PowerBankType type;

    }
    void Start()
    {
       player=FindObjectOfType<PlayerHealth>(); 
    }
    

    


    // Update is called once per frame
    void Update()
    {
        
    }
}

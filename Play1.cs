using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemy;
    MapAccess map;
    void Start()
    {
    	map=FindObjectOfType<MapAccess>();
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(map.isActive==true){
    		enemy.SetActive(true);
    	}
    	
    }
}

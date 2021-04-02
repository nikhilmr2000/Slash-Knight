using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject theEnemy;
    private int xPos;
    private int zPos;
    //private int yPos;
    private int enemyCount;
    void Start()
    {
       StartCoroutine(EnemyDuplicator());
    }

    IEnumerator EnemyDuplicator(){
    	while(enemyCount<14){
    		xPos=Random.Range(1029,904);
    		zPos=Random.Range(-886,-633);
            //yPos=Random.Range(-0,80);
    		Instantiate(theEnemy,new Vector3(xPos,0,zPos),Quaternion.identity);
    		yield return new WaitForSeconds(0.0000001f);
    		enemyCount++;
    	}


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

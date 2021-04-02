using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float damage=0.5f;
    PlayerHealth player;
    CapsuleCollider boxCollider;
    void Start()
    {
        player=FindObjectOfType<PlayerHealth>();
        //player=GetComponent<PlayerHealth>();
        boxCollider=GetComponent<CapsuleCollider>();
    }

    private void OnParticleCollision(GameObject other){
    	//boxCollider.isTrigger=false;
    	if(other.tag=="Player"){
    	Debug.Log("HIT1");
    	player.hitPoints-=damage;
    	Debug.Log("HIT2");
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gameObject;
    void Start()
    {
        Instantiate(gameObject,new Vector3(913,0,-786),Quaternion.identity);
        Instantiate(gameObject,new Vector3(1087,0,-616),Quaternion.identity);
        Instantiate(gameObject,new Vector3(1432,0,-768),Quaternion.identity);
        Instantiate(gameObject,new Vector3(1227,0,-997),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DeathDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI textUI;
    [SerializeField] TextMeshProUGUI aliveUI;
    [SerializeField] TextMeshProUGUI mushUI;
    //Healer1[] healer;
    //private static int currentHealth=0;
    public int currentHealth;
    private static int aliveHealth=71;
    public int mushHealth;
    void Start()
    {
        //healer=FindObjectOfType<Healer1>();
    }

    public void HealthStarter(){

    	GameObject[] enemy= GameObject.FindGameObjectsWithTag ("Respawn");
    	int aliveEnemy=enemy.Length;
    	currentHealth=70-aliveEnemy;
    	textUI.text=currentHealth.ToString();

    }
    private void AliveStarter(){
    	GameObject[] thingyToFind = GameObject.FindGameObjectsWithTag ("Respawn");
    	int aliveHealth = thingyToFind.Length;
    	aliveUI.text=aliveHealth.ToString();

    }

    public void MushroomStarter(){
    	GameObject[] enemy=GameObject.FindGameObjectsWithTag("Finish");
    	int mush=enemy.Length;
    	mushHealth=5-mush;
    	mushUI.text=mushHealth.ToString();

    }
    // Update is called once per frame
    void Update()
    {
    	HealthStarter();
    	AliveStarter();
    	MushroomStarter();
    	//Debug.Log(currentHealth);
    	if(currentHealth==70 && mushHealth==5){
    		WinUIDisplay();
    	}
    }

    private void WinUIDisplay(){
    	//do a UI for winning the match here
    	Debug.Log("YOU WON");
    }
}
 

/*if(healer.totalLife<=0){
    		currentHealth+=1;
    		textUI.text=currentHealth.ToString();
*/



/*
healer=FindObjectsOfType<Healer1>();
    	foreach(Healer1 heal in healer){
    		if(heal.totalLife<=0){
    			currentHealth++;
    			textUI.text=currentHealth.ToString();

    		}
*/
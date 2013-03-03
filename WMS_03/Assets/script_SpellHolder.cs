using UnityEngine;
using System.Collections;

public class script_SpellHolder : MonoBehaviour {
	
	public Transform palmSpawn;
	public GameObject cubeSpawn;
	
	Hashtable spellCombinations = new Hashtable();
	string spellStack = "";
	int spellCounter = 0;
	
	bool fireCast = false;
	bool waterCast = false;
	bool airCast = false;
	bool earthCast = false;
	
	//Prefabs for the spells
	public GameObject prefabFireBall;
	public GameObject prefabWaterBolt;
	public GameObject prefabAirWave;
	public GameObject prefabBoulder;

	// Use this for initialization
	void Start () {
		spellInitialisation();
	}
	
	// Update is called once per frame
	void Update () {
	
		SpellCast();	
	}
	
	private void spellInitialisation()
	{
		spellCombinations.Add("Fira", prefabFireBall);
		spellCombinations.Add("Aera", prefabAirWave);
		spellCombinations.Add("Nero", prefabWaterBolt);
		spellCombinations.Add("Quanos", prefabBoulder);
	}
	
		private void resetSpellCounters()
	{
		spellCounter = 0;
		spellStack = "";
		fireCast = false;
		waterCast = false;
		earthCast = false;
		airCast = false;
	}
	
	private void SpellCast()
	{
		if(spellCounter < 1)
		{	
			if(Input.GetKeyDown(KeyCode.Alpha1) && fireCast == false)
			{
				Instantiate(prefabFireBall, palmSpawn.transform.position, gameObject.transform.rotation);
				spellStack = spellStack + "Fira";
				fireCast = true;
				spellCounter++;
			}
			else if(Input.GetKeyDown(KeyCode.Alpha2) && waterCast == false)
			{
				Instantiate(prefabWaterBolt, palmSpawn.transform.position, gameObject.transform.rotation);
				spellStack = spellStack + "Nero";
				waterCast = true;
				spellCounter++;
			}
			else if(Input.GetKeyDown(KeyCode.Alpha3) && airCast == false)
			{
				Instantiate(cubeSpawn, palmSpawn.transform.position, gameObject.transform.rotation);
				spellStack = prefabAirWave + "Aera";
				airCast = true;
				spellCounter++;
			}
			else if(Input.GetKeyDown(KeyCode.Alpha4) && earthCast == false)
			{
				Instantiate(prefabBoulder, palmSpawn.transform.position, gameObject.transform.rotation);
				spellStack = spellStack + "Quanos";
				earthCast = true;
				spellCounter++;
			}
		}
		
		resetSpellCounters();
		
		//if(Input.GetButtonDown("Fire1"))
		//{
		//	initialiseSpell();
		//	resetSpellCounters();
			//animation.Play("focus grab");
		//}
	}
	
	/*private void initialiseSpell()
	{
		if(spellCombinations.Contains(spellStack))
		{
			GameObject newSpell = (GameObject)spellCombinations[spellStack];
			
			//This works for the spawning of the spells. It looks at the rotation of the main camera on the player and spawns a script based upon it.
			Instantiate(newSpell, transform.position, Camera.main.transform.rotation);
		}
		
	}*/
	
	//This is a test for the massive balls
	
	public Transform GetPalmLocation()
	{
		return palmSpawn;
	}
}

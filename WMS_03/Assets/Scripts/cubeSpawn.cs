using UnityEngine;
using System.Collections;

public class cubeSpawn : MonoBehaviour {
	
	private GameObject playerReference;
	private Transform spawnLocation;
	
	private bool justSpawned;
	private bool notFired;
	
	// Use this for initialization
	void Start () {
		playerReference = GameObject.FindGameObjectWithTag("Player");
		justSpawned = true;
		notFired = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(justSpawned)
		{
			spawnLocation = playerReference.GetComponent<script_SpellHolder>().GetPalmLocation();
			transform.position = spawnLocation.position;
			
		}
		
		if(playerReference.animation["cast"].normalizedTime >= 0.65f)
		{	
			if(notFired)
			{
				justSpawned = false;
				rigidbody.velocity = transform.TransformDirection(Vector3.forward * 10);
				Destroy(GetComponent<MouseLook>());
				notFired = false;
			}
		}
	
	}
}

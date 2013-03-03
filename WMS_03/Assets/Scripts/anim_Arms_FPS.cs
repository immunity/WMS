using UnityEngine;
using System.Collections;

public class anim_Arms_FPS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		animation.Play("idle");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			animation.CrossFade("focus",0.2f);
			//animation.Play("focus");
		}
		
		if(Input.GetButtonDown("Fire1"))
		{
			animation.CrossFade("cast", 0.2f);
			
		}
		
		if(!animation.isPlaying)
		{
			animation.CrossFade("focus_idle",0.2f);
		}
	}
}

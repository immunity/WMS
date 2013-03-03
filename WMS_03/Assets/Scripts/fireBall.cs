using UnityEngine;
using System.Collections;

public class fireBall : spellBase {
	
	// Use this for initialization
	void Start () {
		//velocity = 5;
		rigidbody.velocity = transform.TransformDirection(Vector3.forward * velocity);
		
	}
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit spellHit;
		/*if(Physics.SphereCast(ray, 0.5f, out spellHit))
		{
			Debug.Log(spellHit.collider.gameObject.name);
			if(spellHit.collider.gameObject.name == "Water Fountain")
			{
				Destroy(spellHit.collider.gameObject);
			}
		}*/
	}
	
	void OnCollisionEnter(Collision spellCollision)
	{
		if(spellCollision.collider.gameObject.name != "Cube")
		{
			Debug.Log(spellCollision.gameObject.name);
		}
	}
}

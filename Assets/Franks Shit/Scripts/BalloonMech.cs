using UnityEngine;
using System.Collections;

public class BalloonMech : MonoBehaviour {

	public float gas;
	
	// Update is called once per frame
	void FixedUpdate () {
		if(StaticShit.gasOn){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,gas));
		}
	}
}

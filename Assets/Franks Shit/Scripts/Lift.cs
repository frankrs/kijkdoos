using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		StaticShit.gasOn = Input.GetKey("escape");
	}
}

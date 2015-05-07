using UnityEngine;
using System.Collections;

public class BalloonControls : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	//sort out the input
		StaticShit.gasOn = Input.GetButton("Gas");
	}
}


[System.Serializable]
public static class StaticShit{

	public static bool gasOn;

}
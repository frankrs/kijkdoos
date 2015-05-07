using UnityEngine;
using System.Collections;

public class BalloonControls : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	//sort out the input
//#if UNITY_EDITOR
//		StaticShit.gasOn = Input.GetButton("Gas");
//#endif


//#if UNITY_ANDROID
//		StaticShit.gasOn = Input.GetKey("escape");
//#endif


		StaticShit.gasOn = Input.GetKey("escape");

//
}

}


[System.Serializable]
public static class StaticShit{

	public static bool gasOn;

}
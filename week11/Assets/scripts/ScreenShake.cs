using UnityEngine;
using System.Collections;

// place this on a cannonball object (or, any object we want to clone!)
public class ScreenShake : MonoBehaviour {

	// each cannonball clone will start with 1.0 (100%) shakeStrength
	float shakeStrength = 1f;

	// Update is called once per frame
	void Update () {
		// check to see if the ball is close enough to y=0, which means it hit the ground
		if (transform.position.y < 0.5f) {
			// note that this is an unstable implementation... after enough shakes,
			// the camera will eventually drift (because it doesn't remember where it started)
			Camera.main.transform.position += Camera.main.transform.right * 
												Mathf.Sin (Time.time * 50f) * 
												0.1f * shakeStrength;

			// after 1 second, shakeStrength will go from 1 to 0
			shakeStrength -= Time.deltaTime;

			// Clamp functions limit values to a certain range... here, between 0 and 1
			shakeStrength = Mathf.Clamp ( shakeStrength, 0f, 1f );
		} // end if statement
		
	} // end update
} // end class

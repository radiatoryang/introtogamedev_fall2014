using UnityEngine;
using System.Collections;

public class PhysicsInput : MonoBehaviour {

	public float speed = 5f; // remember, "public" exposes a var in the inspector

	// FixedUpdate is called on a fixed time interval; Physics runs at this framerate
	void FixedUpdate () {

		// is "W" being held down on the keyboard?
		if ( Input.GetKey (KeyCode.W) ) {
			// transform.up automatically calculates the object's "local up" in global worldspace
			GetComponent<Rigidbody>().AddForce( transform.up * speed );
		}

		// turn left code
		if ( Input.GetKey (KeyCode.A) ) {
			GetComponent<Rigidbody>().AddTorque( 0f, 0f, 1f );
		}

		// turn right code
		if ( Input.GetKey ( KeyCode.D) ) {
			GetComponent<Rigidbody>().AddTorque( 0f, 0f, -1f );
		}

	}

}

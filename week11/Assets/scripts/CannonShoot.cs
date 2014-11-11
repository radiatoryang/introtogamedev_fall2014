using UnityEngine;
using System.Collections;

// place this on our cube, to make it shoot cannonballs
public class CannonShoot : MonoBehaviour {

	// to tell Unity what we want to make clones of, we need an original object to clone!
	public Transform originalCannonball; // assign in Inspector

	// Use this for initialization
	void Start () {
		// test out instantiation
		Instantiate( originalCannonball, transform.position, Quaternion.Euler(0f, 90f, 0f) );
	}
	
	// Update is called once per frame
	void Update () {
		// if I press spacebar, spawn a cannonball
		if ( Input.GetKeyDown (KeyCode.Space) ) {
			Instantiate( originalCannonball, transform.position + transform.forward, Quaternion.Euler(0f, 90f, 0f) );
		}
	}
}

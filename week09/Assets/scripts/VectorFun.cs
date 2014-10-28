using UnityEngine;
using System.Collections;

public class VectorFun : MonoBehaviour {

	public float speed = 5f; // "public" in Unity also exposes it to Inspector

	// Update is called once per frame
	void Update () {
		// GetComponent<Transform>().position = new Vector3( 3.252f, 30f, 7f);
		// lowercase "transform" is just a shortcut for GetComponent<Transform>()
		// framerate DEPENDENT behavior
		// transform.position += new Vector3(0f, 1f, 0f);

		// framerate INDEPENDENT behavior
		transform.position += new Vector3(0f, 1f, 0f) * Time.deltaTime * speed;
		Debug.Log ( Time.deltaTime );
		// Time.deltaTime is the FRACTION OF A SECOND in between each frame
		// if the framerate is HIGH, then deltaTime will be low / small
		// but if the framerate is LOW, then deltaTime will be large / high
	}
}

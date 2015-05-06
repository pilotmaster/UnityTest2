using UnityEngine;
using System.Collections;

public class Scr_Rotator : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		// Rotate the cube pick up about its transform
		transform.Rotate (new Vector3(20.0f, 30.0f, 45.0f) * Time.deltaTime);
	}
}

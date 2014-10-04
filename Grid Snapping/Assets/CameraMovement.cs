using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	private Vector3 offset;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = cube.transform.position + offset;
	}
}

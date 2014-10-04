using UnityEngine;
using System.Collections;

public class PositionGameObj : MonoBehaviour {
	public float fieldSize;
	private bool placed = false;
	public Camera snappingCamera;
	// Use this for initialization

	void Start () {
	
	}
	void FixedUpdate()
	{ 
		//Vector3 mouseRealMovement = Input.mousePosition;
		//Vector3 mouseNeedMovement = new Vector3 (mouseRealMovement.x, 5, mouseRealMovement.z);
		Ray theLine = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 newPos = theLine.GetPoint (15);

		Ray ray = snappingCamera.ScreenPointToRay (Input.mousePosition);
		Vector3 point = ray.origin + (ray.direction * 15);
		Vector3 snapPosition = new Vector3 (point.x, 5, point.z);

		if (!placed) 
		{
			this.transform.position = newPos;
			if(Input.GetMouseButtonDown(0))
			{
				this.transform.position = snapPosition;
				placed = true;
			}
		} 
		else 
		{
			this.transform.position = new Vector3 (RoundUpToFieldSize (this.transform.position.x), this.transform.position.y, RoundUpToFieldSize (this.transform.position.z));
		}
	}
	private float RoundUpToFieldSize(float value)
	{
		Debug.Log (Mathf.Floor (value / this.fieldSize) * fieldSize);
		return Mathf.Ceil(value/this.fieldSize)*fieldSize;
	}
	// Update is called	once per frame
	void Update () {

	
	}
}

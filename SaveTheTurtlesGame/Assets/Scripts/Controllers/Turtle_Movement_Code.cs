using UnityEngine;

public class Turtle_Movement_Code : MonoBehaviour {

	public Rigidbody rigMov;

	public float forwardMovement = 300f;// north == +z south == -z
	public float sidewaysMovement = 200f;// left == -x right == +z
	// Update is called once per frame
	void FixedUpdate () {
		rigMov.AddForce (sidewaysMovement * Time.deltaTime, 0, forwardMovement * Time.deltaTime);
	}
}

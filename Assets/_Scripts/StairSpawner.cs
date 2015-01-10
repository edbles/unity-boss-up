using UnityEngine;
using System.Collections;

public class StairSpawner : MonoBehaviour {
	public float stairSpeed;
	public GameObject upStair;
	public GameObject downStair;
	
	private Vector3 startPosition;
	private Vector2 stairVectorSpeed;

	// Use this for initialization
	void Start () {

		startPosition = new Vector3 (3.5f, -0.0907917f, 0.0f);
		stairVectorSpeed = new Vector2(-stairSpeed, 0);
	
	}
	
	// Update is called once per frame
	void Update () {
		bool isUpStair = true;
		if (Random.value < .5) {
			isUpStair = false;
		}

		if (isUpStair) {
			upStair.rigidbody2D.position = startPosition;
			upStair.rigidbody2D.velocity = stairVectorSpeed;

		}
		else {
			downStair.rigidbody2D.position = startPosition;
			downStair.rigidbody2D.velocity = stairVectorSpeed;
		}

	}
}

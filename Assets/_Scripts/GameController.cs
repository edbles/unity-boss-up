using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public GameObject upRamp;
	public GameObject downRamp;
	public GameObject background;

	public float startWait;
	public float stairSpawnWait;
	public float worldSpeed;

	//private string gameState = "";
	private Vector3 stairStartPos = new Vector3(3.5f, -0.0907917f, 0.0f);
	private Vector3 onScreenStart = new Vector3 (0.0f, 0.0f, 0.0f);
	private Vector3 offScreenStart = new Vector3 (5.9f, 0.0f, 0.0f);
	private Vector2 stairVectorSpeed;
	private float score;



	// Use this for initialization
	void Start () {
		score = 0;
		StartCoroutine (SpawnStairs ());
		SpawnBackground ();
	
	}

	IEnumerator SpawnStairs(){	
	
				yield return new WaitForSeconds (startWait);


				while (true) {
	
						if (Random.value < .5) {
								Instantiate (upRamp, stairStartPos, Quaternion.identity);
								yield return new WaitForSeconds (Random.Range (3, 7));
						} else {
								Instantiate (downRamp, stairStartPos, Quaternion.identity);
								yield return new WaitForSeconds (Random.Range (3, 7));
		
						}

				}
		}

	void SpawnBackground(){

		Instantiate (background, onScreenStart, Quaternion.identity);
		Instantiate (background, offScreenStart, Quaternion.identity);


	}
	//IEnumerator SpawnHazards(){
	//	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + score;


	}


}

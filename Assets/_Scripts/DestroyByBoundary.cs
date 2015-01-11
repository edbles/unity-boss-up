using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {




	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "upRamp" || other.tag == "downRamp") {

			Destroy(other.gameObject);
		}
	}
}

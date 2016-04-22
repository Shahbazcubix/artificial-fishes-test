using UnityEngine;
using System.Collections;

public class BassController : MonoBehaviour {
	public GameObject character;
	private float speed = 2.0f;
	private float factor = 0.084f;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.RightArrow)){ // we'd need to decide if we need to move or rotate.
			/*if (character.transform.rotation.y != -180f) {
				Quaternion target = Quaternion.Euler(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
				character.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 2.0f);

			} else {*/
				Vector3 newPosition = character.transform.position;
				newPosition.x += factor;
				character.transform.position = newPosition;
			//}

		} 
		if (Input.GetKey(KeyCode.LeftArrow)){ 
			Vector3 newPosition = character.transform.position;
			newPosition.x-= factor;
			character.transform.position = newPosition;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			Vector3 newPosition = character.transform.position;
			newPosition.z+= factor;
			character.transform.position = newPosition;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			Vector3 newPosition = character.transform.position;
			newPosition.z-= factor;
			character.transform.position = newPosition;
		}

	}
}

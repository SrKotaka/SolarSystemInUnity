using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
	public AudioSource music;

	void Start() {
		if (target == null) 
		{
			target = gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
		if (!gameObject.TryGetComponent(out music))
			target.TryGetComponent(out music);
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		LookAtTarget.target = target;
		LookAtTarget.music = music;
		Camera.main.fieldOfView = 60*target.transform.localScale.x;
	}
}

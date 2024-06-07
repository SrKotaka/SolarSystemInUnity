using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour
{
	static private AudioSource _music;

	static public AudioSource music
	{
		set
		{
			if (_music != null && _music.isPlaying)
				_music.Stop();
			_music = value;
			if (_music != null && !_music.isPlaying)
				_music.Play();
		}
	}
	static public GameObject target;

	void Start () {
		if (target == null) 
		{
			target = gameObject;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (target)
		{
			transform.LookAt(target.transform);
		}
	}
}

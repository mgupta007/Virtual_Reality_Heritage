using UnityEngine;
using System.Collections;

public class sound1 : MonoBehaviour {

	public AudioSource source;
	public AudioClip clip;
	private bool isPlayed;

	public void Awake()
	{

		source = GetComponent<AudioSource> ();
		isPlayed = false;
	}

	public void OnTriggerEnter(Collider other){
		if (!isPlayed) {
			source.Play ();
			isPlayed = true;
		}

	}
		
	public void OnTriggerExit(Collider other){

		if (source.isPlaying) {
			source.Stop ();
		}
	}

}

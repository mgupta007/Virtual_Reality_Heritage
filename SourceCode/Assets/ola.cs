using UnityEngine;
using System.Collections;

public class ola : MonoBehaviour {

	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel (SceneToChange);
	}
}

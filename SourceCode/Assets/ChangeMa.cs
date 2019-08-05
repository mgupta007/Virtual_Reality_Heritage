using UnityEngine;
using System.Collections;

public class ChangeMa : MonoBehaviour {

	// Update is called once per frame
	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);

	}
}


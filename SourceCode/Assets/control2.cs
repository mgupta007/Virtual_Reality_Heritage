using UnityEngine;
using System.Collections;

public class control2 : MonoBehaviour {



	// Update is called once per frame
	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);

	}
}

using UnityEngine;
using System.Collections;

public class change_mahal : MonoBehaviour {

	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);

	}
}
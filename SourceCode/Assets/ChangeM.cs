using UnityEngine;
using System.Collections;

public class ChangeM : MonoBehaviour {


	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);

	}
}

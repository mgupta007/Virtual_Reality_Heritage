using UnityEngine;
using System.Collections;

public class SCENE_CHANGE : MonoBehaviour {


	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);

	}
}
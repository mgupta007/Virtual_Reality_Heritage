using UnityEngine;
using System.Collections;

public class CHANGE_NAUBAT : MonoBehaviour {

	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);

	}
}
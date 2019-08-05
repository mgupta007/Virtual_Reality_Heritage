using UnityEngine;
using System.Collections;

public class control1 : MonoBehaviour {


	public void ChangeToScene (string SceneToChange) {
		Application.LoadLevel(SceneToChange);
	
	}
}

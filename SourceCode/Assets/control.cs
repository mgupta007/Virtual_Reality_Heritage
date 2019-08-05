using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

	
	
	
	public void ChangeToScene (string sceneToChangeTo) {
        Application.LoadLevel(sceneToChangeTo);
	}
}

using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {
	
	
	public void Update (string SceneToChange) {
        Application.LoadLevel(SceneToChange);
	}
}

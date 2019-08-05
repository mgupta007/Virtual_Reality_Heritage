using UnityEngine;
using System.Collections;

public class CardboardToggle : MonoBehaviour {

    int vrModeInt;

    public void ToggleVRMode()
    {
        if(PlayerPrefs.GetInt("Vr Mode") == 1)
        {
            vrModeInt = 0;
        }
        if(PlayerPrefs.GetInt("Vr Mode") == 0)
        {
            vrModeInt = 1;
        }
        PlayerPrefs.SetInt("Vr Mode", vrModeInt);
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Vr Mode") == 0)
        {
            GvrViewer.Instance.VRModeEnabled = true;
        
        }
        if(PlayerPrefs.GetInt("Vr Mode") == 1)
        {
            GvrViewer.Instance.VRModeEnabled = false;
        }
	
	}
}

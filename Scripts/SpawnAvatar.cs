using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAvatar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if (PlayerPrefs.GetString("avatar") == "sapi")
	    // {
	    // 	sapi.setActive(true);
	    // 	gajah.setActive(false);
	    // }
	    // else if (PlayerPrefs.GetString("avatar") == "gajah")
	    // {
	    // 	sapi.setActive(false);
	    // 	gajah.setActive(true);
	    // }

            Debug.Log(PlayerPrefs.GetString("avatar"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

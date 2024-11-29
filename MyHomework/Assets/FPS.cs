using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
	public Text ScriptTxt;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string fps = "fps = " + 1/Time.deltaTime;
        ScriptTxt.text = fps;  
    }
}

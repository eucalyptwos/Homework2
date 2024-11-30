using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInfo : MonoBehaviour
{
    public int enemyKill;
    public Text txt;
	// Start is called before the first frame update
	void Start()
    {
        enemyKill = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text =enemyKill + "/11";

	}
}

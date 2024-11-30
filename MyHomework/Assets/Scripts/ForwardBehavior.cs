using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardBehavior : MonoBehaviour
{
    public float speed;
    public float delay;
    // Start is called before the first frame update
    void Start()
    { 
        delay = 3;
		Destroy(gameObject, delay);
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,speed*Time.deltaTime);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceBehavior : MonoBehaviour
{
    public float speed;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //추적기능 구현.
        transform.Translate(0,0,speed*Time.deltaTime);
		Destroy(gameObject, delay);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab1;
	public GameObject prefab2;
	public GameObject ShootPoint;
	public ParticleSystem cartridge;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clone;

		if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(GetComponent<PlayerMovement>().ammoType ==0) clone = Instantiate(prefab1); else clone = Instantiate(prefab2);
            clone.transform.position = ShootPoint.transform.position;
            clone.transform.rotation = ShootPoint.transform.rotation;
            cartridge.Play();
            

		}
        
	}   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab1;
	public GameObject prefab2;
	public GameObject ShootPoint;
	public ParticleSystem cartridge;
    public AudioSource shootsound;
    private float attackcooltime = 0f;
    // Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clone;
        if(attackcooltime>0f)
            attackcooltime -= Time.deltaTime;
		if (Input.GetMouseButton(0))
        {
            if (attackcooltime <= 0f)
            {
                attackcooltime = 0.15f;
                if (GetComponent<PlayerMovement>().ammoType == 0) clone = Instantiate(prefab1); else clone = Instantiate(prefab2);
                clone.transform.position = ShootPoint.transform.position;
                clone.transform.rotation = ShootPoint.transform.rotation;
                cartridge.Play();
                shootsound.Play();
            }

		}
        
	}   
}

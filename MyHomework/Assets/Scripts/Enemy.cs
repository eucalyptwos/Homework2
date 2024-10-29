using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float hp;
    // Start is called before the first frame update
    void Start()
    {
       if (hp < 0) hp = 100;

	}

    // Update is called once per frame
    void Update()
    {
    }
}

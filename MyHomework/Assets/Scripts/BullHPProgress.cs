using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BullHPProgress : MonoBehaviour
{
    private float bullHp;
    public float bullHPinitial=3000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullHp=gameObject.GetComponent<Enemy>().hp/ bullHPinitial;
        if(GameObject.Find("ProgressHP")!=null)
            GameObject.Find("ProgressHP").GetComponent<Slider>().value = bullHp;
    }
}

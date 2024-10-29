using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class MyFIrstScript : MonoBehaviour
{
    [SerializeField]
    public float speed;
    
    void Start()
    {
        print(message:"tset start");    
    }

    // Update is called once per frame
    void Update()
    {
        print("test");
    }
}

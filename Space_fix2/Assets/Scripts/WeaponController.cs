using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject prefab;
    public Transform holsterTransform;
    public Transform RifleTransform; // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Quaternion quaternion = Quaternion.Euler(0f, 0f, 0f);
            Instantiate(prefab, RifleTransform.position, quaternion);
        }
    }
}

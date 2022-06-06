using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraHareketi : MonoBehaviour
{
    public Transform target;  //kimi takip edecek ?
    public Vector3 offset;   //takip etme mesafesi
    
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, 
            target.position + offset, Time.deltaTime * 2);
    }
}

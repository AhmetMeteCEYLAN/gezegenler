using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marsrotate : MonoBehaviour
{

    public Vector3 vect3;
    // Start is called before the first frame update
    void Start()
    {
        vect3= new Vector3(0,0.8f,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vect3);
    }
}
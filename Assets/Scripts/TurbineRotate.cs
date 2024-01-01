using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbineRotate : MonoBehaviour
{
    public Vector3 rotateturbine;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateturbine * Time.deltaTime);
    }
}

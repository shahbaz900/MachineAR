using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEnabler : MonoBehaviour
{
    public GameObject turbineobj;
    bool isactive = true;
    public void HideObj()
    {
        if (isactive)
        {
            turbineobj.SetActive(false);
            isactive = false;
        }
        else
        {
            turbineobj.SetActive(true);
            isactive = true;
        }
    }
}

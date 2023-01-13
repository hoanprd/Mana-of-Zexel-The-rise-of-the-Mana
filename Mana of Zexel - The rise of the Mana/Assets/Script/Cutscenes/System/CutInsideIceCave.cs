using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutInsideIceCave : MonoBehaviour
{
    public GameObject CutTrigger1;

    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus65 == 1)
        {
            Destroy(CutTrigger1);
        }
    }
}

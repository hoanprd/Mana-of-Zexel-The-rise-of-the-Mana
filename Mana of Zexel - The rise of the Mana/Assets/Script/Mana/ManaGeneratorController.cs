using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaGeneratorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (CutscenesController.cus57 == 0)
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

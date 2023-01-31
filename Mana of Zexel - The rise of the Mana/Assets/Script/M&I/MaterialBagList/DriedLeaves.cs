using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DriedLeaves : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.DriedLeaves;

        if (ContainerController.DriedLeaves <= 0)
        {
            Destroy(gameObject);
        }
    }
}

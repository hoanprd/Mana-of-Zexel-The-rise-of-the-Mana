using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NatureGrass : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.NatureGrass;

        if (ContainerController.NatureGrass <= 0)
        {
            Destroy(gameObject);
        }
    }
}

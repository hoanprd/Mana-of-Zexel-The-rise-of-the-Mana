using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireManaGenerator : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.FireManaGenerator;

        if (ContainerController.FireManaGenerator <= 0)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Iron : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.Iron;

        if (ContainerController.Iron <= 0)
        {
            Destroy(gameObject);
        }
    }
}

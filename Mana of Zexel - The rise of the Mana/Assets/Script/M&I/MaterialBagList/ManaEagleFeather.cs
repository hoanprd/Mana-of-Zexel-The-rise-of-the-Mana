using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaEagleFeather : MonoBehaviour
{
    public Text num;

    // Update is called once per frame
    void Update()
    {
        num.text = "" + ContainerController.ManaEagleFeather;

        if (ContainerController.ManaEagleFeather <= 0)
        {
            Destroy(gameObject);
        }
    }
}

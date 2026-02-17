using System.Collections;
using System.Collections.Generic;
using FGUIStarter;
using UnityEngine;

public class AddHomeFunc : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.GetComponentInParent<CustomButton>().targetSceneIndex = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    public void Interact()
    {
        Debug.LogErrorFormat("{0} interact", gameObject.name);
    }
}
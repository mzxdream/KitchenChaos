using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public void Interact()
    {
        Debug.LogFormat("{0} interact", gameObject.name);
        var kitchenObjTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitchenObjTransform.localPosition = Vector3.zero;
        Debug.LogFormat("kitchen object name {0}", kitchenObjTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
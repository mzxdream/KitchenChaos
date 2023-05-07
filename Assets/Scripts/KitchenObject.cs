using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private ClearCounter clearCounter;
    
    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        if (clearCounter.HasKitchenObject())
        {
            Debug.LogErrorFormat("clear counter already has a kitchen object");
            return;
        }
        if (this.clearCounter != null)
        {
            this.clearCounter.ClearKitchenObject();
        }
        this.clearCounter = clearCounter;
        clearCounter.SetKitchObject(this);
        this.transform.SetParent(clearCounter.GetKitchenObjectFollowTransform());
        this.transform.localPosition = Vector3.zero;
    }

    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CartCollection : MonoBehaviour
{
   public int NumberOfCarts { get; private set; }

    public UnityEvent<CartCollection> OnCartCollected;
    public void CartCollected()
    {
        NumberOfCarts++;
        OnCartCollected.Invoke(this);
    }
}

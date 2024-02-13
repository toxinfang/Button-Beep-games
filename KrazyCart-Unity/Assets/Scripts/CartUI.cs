using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartUI : MonoBehaviour
{

    private TextMeshProUGUI cartText;
    // Start is called before the first frame update
    void Start()
    {
        cartText = GetComponent<TextMeshProUGUI>();
    }

    public void updateCartText(CartCollection cartCollection)
    {
        cartText.text = cartCollection.NumberOfCarts.ToString() + " /11";
    }
}

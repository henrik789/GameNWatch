using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//game object Input handles user left/right input colliders.
//check left box in script component. 

public class Input : MonoBehaviour
{

    public delegate void ButtonPressed();
    public static event ButtonPressed OnLeftPressed;
    public static event ButtonPressed OnRightPressed;

    public bool left;

    private void OnMouseDown()
    {
        if (OnLeftPressed != null && left)
            OnLeftPressed();
        else if (OnRightPressed != null)
            OnRightPressed();

    }
}
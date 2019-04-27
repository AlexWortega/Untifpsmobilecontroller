using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class controller : MonoBehaviour
{
    public FixedJoystick Joystick;
    public FixedButton Jumpbutton;
    public FixedTouchField TouchField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.Runaxis = Joystick.Direction;
        fps.jumpaxis = Jumpbutton.Pressed;
        fps.mouseLook.lookaxis = TouchField.TouchDist;

    }
}

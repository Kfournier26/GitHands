using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;

public class GenericHandInputManager : Singleton<GenericHandInputManager>
{
    public OVRInput.Controller Controller;
    
	// Use this for initialization
	protected override void Awake () {
        _leftHand = new HandControllerInput { hand = HandControllerType.LeftHand };
        _rightHand = new HandControllerInput { hand = HandControllerType.RightHand };
    }

    private HandControllerInput _leftHand, _rightHand;

    public HandControllerInput LeftHand
    {
        get
        {
            return _leftHand;
        }
    }

    public HandControllerInput RightHand
    {
        get
        {
            return _rightHand;
        }
    }
}

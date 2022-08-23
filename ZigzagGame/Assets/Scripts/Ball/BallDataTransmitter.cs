using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmitter : MonoBehaviour
{
    [SerializeField] private BallInputController ballInputController;

    public Vector3 GetballDirection()
    {
        return ballInputController.ballDirection;
    }
}

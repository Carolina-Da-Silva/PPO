using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rumble : MonoBehaviour
{
    private Gamepad pad;

    private void OnCollisionEnter(Collision collision)
    {
        pad = Gamepad.current;
        if (pad == null) return;

        if (collision.gameObject.tag == "hi") {
            pad.SetMotorSpeeds(1, 0);
            return;
        }

        if (collision.gameObject.tag == "low") {
            pad.SetMotorSpeeds(0, 1);
            return;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        pad = Gamepad.current;
        if (pad == null) return;
        pad.SetMotorSpeeds(0.0f, 0.0f);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class James_Controller : MonoBehaviour
{
    public IK_RightArm rightArm;
    public IK_LeftArm leftArm;
    public GrapplingController rightHook;
    public GrapplingController leftHook;
    public IK_LookAt look;
    public IK_RightLeg rightLeg;
    public IK_LeftLeg leftLeg;

    public void RightArmAim() {
        rightArm.canIK = true;
        rightHook.Aim();
    }

    public void LeftArmAim() {
        leftArm.canIK = true;
        leftHook.Aim();
    }

    public void FireRightHook() {
        rightHook.Fire();
    }

    public void FireLeftHook() {
        leftHook.Fire();
    }

    public void ReelRightHook() {
        rightHook.Reel();
    }

    public void ReelLeftHook() {
        leftHook.Reel();
    }

    public void RightArmUnaim() {
        rightArm.canIK = false;
        rightHook.NoAim();
    }

    public void LeftArmUnaim() {
        leftArm.canIK = true;
        leftHook.NoAim();
    }

    public void Look() {
        look.canLook = true;
    }

    public void DontLook() {
        look.canLook = false;
    }

    public void RightLegAim() {
        rightLeg.canIK = true;
    }

    public void RightLegUnaim() {
        rightLeg.canIK = false;
    }

    public void LeftLegAim() {
        leftLeg.canIK = true;
    }

    public void LeftLegUnaim() {
        leftLeg.canIK = false;
    }
}
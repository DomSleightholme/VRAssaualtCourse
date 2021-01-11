using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectOutline : MonoBehaviour
{
    Outline objectOutline;
    public Color HoverColor;
    public Color CarryingColor;

    // Start is called before the first frame update
    void Start()
    {
        objectOutline = FindObjectOfType<Outline>();

        objectOutline.enabled = false;
    }

    public void OutlineGrabbed(XRBaseInteractor interactor)
    {
        objectOutline.OutlineColor = CarryingColor;
    }

    public void OutlineDropped(XRBaseInteractor interactor)
    {
        objectOutline.OutlineColor = HoverColor;
    }

    public void OutlineActivate(XRBaseInteractor interactor)
    {
        objectOutline.enabled = true;
    }
    public void OutlineDeActivated(XRBaseInteractor interactor)
    {
        objectOutline.enabled = false;
    }
}

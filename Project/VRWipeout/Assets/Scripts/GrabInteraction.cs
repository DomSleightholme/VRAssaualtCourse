using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabInteraction : MonoBehaviour
{
    private void Start()
    {
        var outline = GetComponent<Outline>();
        outline.enabled = false;
    }
    public void onHover()
    {
        var outline = GetComponent<Outline>();
        outline.enabled = true;
    }
    public void onHoverExit()
    {
        var outline = GetComponent<Outline>();
        outline.enabled = false;
    }
}

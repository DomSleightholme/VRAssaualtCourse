using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR.Interaction.Toolkit;

public class VignetteApplier : MonoBehaviour
{
    [Header("Values")]
    public float intensity = 0.75f;
    public float duration = 0.5f;
    public Volume volume = null;

    [Header("Transforms")]
    public LocomotionProvider locomotionProvider;
    private Vignette vignette = null;
    private void Awake()
    {
        //Get the provider
        locomotionProvider = GetComponent<LocomotionProvider>();

        //Get the vignette
        if(volume.profile.TryGet(out Vignette vignette))
        {
            this.vignette = vignette;
        }
    }
    private void OnEnable()
    {
        locomotionProvider.beginLocomotion += FadeIn;
        locomotionProvider.endLocomotion += FadeOut;
    }
    private void OnDisable()
    {
        locomotionProvider.beginLocomotion -= FadeIn;
        locomotionProvider.endLocomotion -= FadeOut;
    }
    public void FadeIn(LocomotionSystem locomotionSystem)
    {
        //Tween to intensity
        StartCoroutine(Fade(0, intensity));
    }
    public void FadeOut(LocomotionSystem locomotionSystem)
    {
        //Tween to Zero
        StartCoroutine(Fade(intensity, 0));
    }

    private IEnumerator Fade(float startValue, float endValue)
    {
        float elapsedTime = 0.0f;

        while(elapsedTime <= duration)
        {
            //Figure out blend value
            float blend = elapsedTime / duration;
            elapsedTime += Time.deltaTime;

            //Apply Intensity
            float intensity = Mathf.Lerp(startValue, endValue, blend);
            ApplyValue(intensity);

            yield return null;
        }
    }

    private void ApplyValue(float value)
    {
        vignette.intensity.Override(value);
    }
}

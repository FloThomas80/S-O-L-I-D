using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDammages : MonoBehaviour
{
    private Image _uIdamage;
    private float fadeDuration = 2f;
    private bool OnlyOne = true;
    private void Start()
    {
       _uIdamage = GetComponent<Image>();
    }
    public void TakeDamageUI(bool OnOff)
    {
            if(OnlyOne)
            { 
            //SoundController_Script.Instance.LaunchAlertSound();
            OnlyOne = false;
            }
            StartCoroutine (FadeToTransparent());
    }

    private IEnumerator FadeToTransparent()
    {
        Color spriteColor = _uIdamage.color;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float normalizedTime = elapsedTime / fadeDuration;
            spriteColor.a = Mathf.Lerp(1f, 0f, normalizedTime);
            _uIdamage.color = spriteColor;
            yield return null;
        }
        spriteColor.a = 0f;
        _uIdamage.color = spriteColor;
    }
}

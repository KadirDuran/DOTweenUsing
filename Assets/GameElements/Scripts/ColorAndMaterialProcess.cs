using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColorAndMaterialProcess : MonoBehaviour
{

    public SpriteRenderer circleRenderer;
    public Renderer sphereRenderer;
    public Image image;
    public TextMeshProUGUI text;
    public float duration = 1.0f;
    private void Start()
    {
        ChangeColor();
    }

    void ChangeColor()//Belirlenen renge ge�i�i sa�lar
    {
        sphereRenderer.material.DOColor(Random.ColorHSV(), duration);
        circleRenderer.DOColor(Random.ColorHSV(), duration); 
        text.DOColor(Random.ColorHSV(), duration);
        image.DOColor(Random.ColorHSV(), duration);
        //Random.ColorHSV() rastgele bir renk uret�r.
    }
    void Fade()
    {

        sphereRenderer.material.DOFade(0.3f, duration); //Opakl�k 0-1 aras� 0.3f l�k saydamla�acak.
        circleRenderer.DOFade(0.3f, duration);
        text.DOFade(0.3f, duration);
        image.DOFade(0.3f, duration);
    }
}

using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIProcess : MonoBehaviour
{
    public RectTransform background;
    public RectTransform[] upTransform;
    public RectTransform[] downTransform;
    public Text txtGold, txtScore;
    public float animDuration = 1f;
    public bool click = false;


    void OnEnable()
    {
        background.DOScale(0f, animDuration).From();
        foreach (var item in upTransform)
        {
            item.DOAnchorPosY(700f, animDuration).From();
        }
        foreach (var item in downTransform)
        {
            item.DOAnchorPosY(-700f, animDuration).From();
        }
        txtGold.text = "";
        txtScore.text = "";

       txtGold.DOText("200",animDuration/2).SetDelay(animDuration); 
       txtScore.DOText("Score : 1200",animDuration/2).SetDelay(animDuration); 
    }

    public void ButtonClickAnim(RectTransform rectTransform)
    {
        if(!click)
        {
            rectTransform.DOScale(rectTransform.localScale * 1.25f, animDuration / 6f).SetLoops(2, LoopType.Yoyo).OnPlay(() =>
            {
                click= true;
            })
            .OnComplete(() =>
            {
                click = false;
            });
        }
        
    }

}
/*
Burada en onemli þey OnEnable olmasý start olsaydý start 1 kere calýsacagý ýcýn anýmasyonlarda 1 kere calýsacaktý
onenable kullandýgýmýzda her aktýf olmada anýmasyonlar tekrar tekrar kullanýlabýlýr hale geldý.
 */
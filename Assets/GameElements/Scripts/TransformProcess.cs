using UnityEngine;
using DG.Tweening;

public class TransformProcess : MonoBehaviour
{
    public GameObject gO1, gO2;
    public Ease ease;
    private void Start()
    {
        
    }

}
/*
gO1.transform.DOMove(new Vector3(2f,2f,-1f),2f);
Verilen kordinata haraket ettirir(hedef,ne kadar surede hedefte olsun)
gO1.transform.DOMoveX(3.3f,1f); 
X'te hedefe belirlenen sürede gider.
gO1.transform.DOMoveY(3.3f,1f);
Y'de hedefe belirlenen sürede gider.

gO1.transform.DOMoveY(3.3f, 1f).SetEase(ease);
Burada ki ease haraketin davranýþ tipidir. Gittikçe hýzlanma, Hýzlý baþlayýp hedefe yaklaþtýkça yavaþlama.

Transform,Rotation ve Scale için ayný kodlar kullanýlýr.
 

gO1.transform.DOScale(new Vector3(3f,3f,3f),1f);Nesnenin Scale'ini verilen deðere verilen zamanda büyütür.
gO1.transform.DOScale(new Vector3(3f,3f,3f),1f).From(); Nesnenin Scale'ini verilen deðerden sahnede bulunduðu deðere götürür. Burdan baþla gibi.
gO1.transform.DOLocalMoveX(3.3f,1f); Parent'ý olan nesne içerde farklý kordinatta ise Local iþlem yapýlýr.
 */
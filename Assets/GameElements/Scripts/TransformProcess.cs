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
X'te hedefe belirlenen s�rede gider.
gO1.transform.DOMoveY(3.3f,1f);
Y'de hedefe belirlenen s�rede gider.

gO1.transform.DOMoveY(3.3f, 1f).SetEase(ease);
Burada ki ease haraketin davran�� tipidir. Gittik�e h�zlanma, H�zl� ba�lay�p hedefe yakla�t�k�a yava�lama.

Transform,Rotation ve Scale i�in ayn� kodlar kullan�l�r.
 

gO1.transform.DOScale(new Vector3(3f,3f,3f),1f);Nesnenin Scale'ini verilen de�ere verilen zamanda b�y�t�r.
gO1.transform.DOScale(new Vector3(3f,3f,3f),1f).From(); Nesnenin Scale'ini verilen de�erden sahnede bulundu�u de�ere g�t�r�r. Burdan ba�la gibi.
gO1.transform.DOLocalMoveX(3.3f,1f); Parent'� olan nesne i�erde farkl� kordinatta ise Local i�lem yap�l�r.
 */
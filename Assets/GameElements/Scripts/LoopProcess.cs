using DG.Tweening;
using UnityEngine;

public class LoopProcess : MonoBehaviour
{
    public GameObject gO1, gO2;
    
    private void Start()
    {
        gO1.transform.DOMoveX(3f,1f).SetLoops(2,LoopType.Incremental);
    }

}
/*
gO1.transform.DOMoveX(3f,1f).SetLoops(2);
X'te 3f'e iki kere gidip durur.
gO1.transform.DOMoveX(3f,1f).SetLoops(-1);
X'te 3f'e sonsuz kere gidip durur.
gO1.transform.DOMoveX(3f,1f).SetLoops(2,LoopType.Incremental);
Ba�lad��� yerden 3f noktas�na olan uzakl�k s�rekli u� uca eklenir. Sonsuza kadar ileri gider bu durumda.
gO1.transform.DOMoveX(3f,1f).SetLoops(2,LoopType.Yoyo);
ba�lad��� kordinattan 3f gider sonra 3f ten ba�lad�g� konuma gider.(baslad�g� konumdan ba�alamaz "gider").
gO1.transform.DOMoveX(3f,1f).SetLoops(2,LoopType.Restart);
ba�lad��� kordinattan 3f gider sonra tekrar ba�lad�g� konumdan ba�lar.
 */
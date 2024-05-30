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
Baþladýðý yerden 3f noktasýna olan uzaklýk sürekli uç uca eklenir. Sonsuza kadar ileri gider bu durumda.
gO1.transform.DOMoveX(3f,1f).SetLoops(2,LoopType.Yoyo);
baþladýðý kordinattan 3f gider sonra 3f ten baþladýgý konuma gider.(basladýgý konumdan baþalamaz "gider").
gO1.transform.DOMoveX(3f,1f).SetLoops(2,LoopType.Restart);
baþladýðý kordinattan 3f gider sonra tekrar baþladýgý konumdan baþlar.
 */
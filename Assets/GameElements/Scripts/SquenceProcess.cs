using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SquenceProcess : MonoBehaviour
{
    public Transform objects;
    void Start()
    {
        Sequence sequence = DOTween.Sequence();
        //2 method var Append olu�turmak i�in ve join ise olu�turulanla ayn� anda olmas� i�in

        sequence.Append(transform.DOMoveX(6f,2f));
        sequence.Join(transform.DOScale(2.5f, 2f));
        sequence.Append(transform.DOMoveY(3f, 2f));
        sequence.Join(transform.DOScale(1f, 2f));
    }

    //Animasyon olu�turmak i�in ideal Scale,Rotate,Position ile ilgili t�m i�lemler yap�labilir s�rayla.
    //Titre�imler,efectler eklebilir.
}

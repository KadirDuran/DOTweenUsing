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
        //2 method var Append oluþturmak için ve join ise oluþturulanla ayný anda olmasý için

        sequence.Append(transform.DOMoveX(6f,2f));
        sequence.Join(transform.DOScale(2.5f, 2f));
        sequence.Append(transform.DOMoveY(3f, 2f));
        sequence.Join(transform.DOScale(1f, 2f));
    }

    //Animasyon oluþturmak için ideal Scale,Rotate,Position ile ilgili tüm iþlemler yapýlabilir sýrayla.
    //Titreþimler,efectler eklebilir.
}

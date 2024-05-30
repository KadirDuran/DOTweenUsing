using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateProcess : MonoBehaviour
{
    public GameObject gO1, gO2;
    Tween tween;
    private void Start()
    {
       //gO1.transform.DOMoveX(3f, 1f).OnComplete(CoinAdd);
      
        //gO1.transform.DOMoveX(3f, 1f).OnUpdate(()=>{ Debug.Log("Ge�en S�re : " + Time.deltaTime); });
        tween = gO1.transform.DOMoveX(3f, 1f).SetLoops(-1).OnPause(CoinAdd);
        //tween = gO1.transform.DOMoveX(3f, 1f).SetLoops(-1)
        //    .OnPlay(() =>
        //    {
        //       //Oynarken
        //    })
        //    .OnPause(() =>
        //    {
        //        //Dururken.
        //    });
        //Farkl� kullan�mlar� var.

    }

    void CoinAdd()
    {
        Debug.Log("Process completed.");

    }
    void TweenState(Tween tweenM,string state)
    {
        if(state == "Play") tweenM.Play();
        else if(state =="Pause") tweenM.Pause();
        else if (state =="Restart") tweenM.Restart();
        else tweenM.Kill();
    }
}
/*
 gO1.transform.DOMoveX(3f, 1f).OnComplete(CoinAdd);
Obje 3f noktas�na gittiginde CoinAdd methodu �al���r.
tween = gO1.transform.DOMoveX(3f, 1f).SetLoops(-1).OnKill(CoinAdd);
Obje 3f noktas�na gittiginde sonsuz dongude oldugu �c�n asl�nda kill tetiklenmez ama tween de�i�kenine 
ald���m�zzaman void TweenState(Tween tweenM,string state) b�yle bir yerde Kill() metodu ile CoinAdd methodunu 
�al��t�rabiliriz.
gO1.transform.DOMoveX(3f, 1f).OnUpdate(()=>{ Debug.Log("Ge�en S�re : " + Time.deltaTime); });
Bu method update methodu gibi. Sadece etkin oldugu sure boyunca.
gO1.transform.DOMoveX(3f, 1f).SetDelay(3f);
3 saniyelik ge�ikmeden sonra i�lem ba�lar.
 */

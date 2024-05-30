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
      
        //gO1.transform.DOMoveX(3f, 1f).OnUpdate(()=>{ Debug.Log("Geçen Süre : " + Time.deltaTime); });
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
        //Farklý kullanýmlarý var.

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
Obje 3f noktasýna gittiginde CoinAdd methodu çalýþýr.
tween = gO1.transform.DOMoveX(3f, 1f).SetLoops(-1).OnKill(CoinAdd);
Obje 3f noktasýna gittiginde sonsuz dongude oldugu ýcýn aslýnda kill tetiklenmez ama tween deðiþkenine 
aldýðýmýzzaman void TweenState(Tween tweenM,string state) böyle bir yerde Kill() metodu ile CoinAdd methodunu 
çalýþtýrabiliriz.
gO1.transform.DOMoveX(3f, 1f).OnUpdate(()=>{ Debug.Log("Geçen Süre : " + Time.deltaTime); });
Bu method update methodu gibi. Sadece etkin oldugu sure boyunca.
gO1.transform.DOMoveX(3f, 1f).SetDelay(3f);
3 saniyelik geçikmeden sonra iþlem baþlar.
 */

using DG.Tweening;
using UnityEngine;

public class EffectProcess : MonoBehaviour
{
    public Vector3 endPos;
    public float jumpPower; //Zýplama gücü
    public int jumpCount; //Hedefe gidene kadar kaç sýçrama
    public float duration; //Zaman

    public float strength; //Sarsýntý uzunlugu
    public int vibrato; //Titreþim sayýsý
    public float randomness;


    public Transform paunchObje; //nesneye bu effectý yaptýracak nesne
    public int elasticity;//esneklik
    private void Start()
    {
       
    }

    void Jump()
    {
        transform.DOJump(endPos, jumpPower, jumpCount, duration);
    }
    void Shake()//Bu effect kutu  açma hedýye kazanma gýbý yerlerde kullanýlabýlýr. Scale'de güzel.
    {
        transform.DOShakePosition(duration, strength, vibrato, randomness);
    }
    void DoPunch()
    {
        transform.DOPunchPosition(paunchObje.transform.position,vibrato,elasticity);
    }
}

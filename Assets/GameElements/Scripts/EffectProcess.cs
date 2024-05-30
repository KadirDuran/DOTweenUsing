using DG.Tweening;
using UnityEngine;

public class EffectProcess : MonoBehaviour
{
    public Vector3 endPos;
    public float jumpPower; //Z�plama g�c�
    public int jumpCount; //Hedefe gidene kadar ka� s��rama
    public float duration; //Zaman

    public float strength; //Sars�nt� uzunlugu
    public int vibrato; //Titre�im say�s�
    public float randomness;


    public Transform paunchObje; //nesneye bu effect� yapt�racak nesne
    public int elasticity;//esneklik
    private void Start()
    {
       
    }

    void Jump()
    {
        transform.DOJump(endPos, jumpPower, jumpCount, duration);
    }
    void Shake()//Bu effect kutu  a�ma hed�ye kazanma g�b� yerlerde kullan�lab�l�r. Scale'de g�zel.
    {
        transform.DOShakePosition(duration, strength, vibrato, randomness);
    }
    void DoPunch()
    {
        transform.DOPunchPosition(paunchObje.transform.position,vibrato,elasticity);
    }
}

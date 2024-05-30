using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PathProcess : MonoBehaviour
{
    public Transform pathParent;
    public float lookAhead;

    private void Start()
    {
        Vector3[] vectors = new Vector3[pathParent.childCount];
        for (int i = 0; i < vectors.Length; i++)
        {
            vectors[i] = pathParent.GetChild(i).position;
        }
        //transform.DOPath(vectors,5f);
        //Gitti�i y�ne bakm�yor
        //transform.DOPath(vectors, 15f).SetLookAt(0.001f,Vector3.left);
        //yollar� cok keskin
        transform.DOPath(vectors, 15f, PathType.CatmullRom).SetLookAt(0.001f,Vector3.left);
        //Yollar� pathtype ile yumusat�yor
    }
}

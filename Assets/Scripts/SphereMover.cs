using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereMover : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveX(-3, 3).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}

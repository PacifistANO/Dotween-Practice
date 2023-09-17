using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMagnifier : MonoBehaviour
{
    void Start()
    {
        transform.DOScale(2, 4).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}

using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoverRotaterMagnifier : MonoBehaviour
{
    private Tweener _tween;

    private void Start()
    {
        _tween = transform.DOMoveX(0, 3).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        _tween = transform.DORotate(new Vector3(0, 180, 0), 5).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        _tween = transform.DOScale(2, 4).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}

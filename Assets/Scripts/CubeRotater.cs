using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotater : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0, 180, 0), 5).SetEase(Ease.Linear).SetLoops(-1,LoopType.Restart);
    }
}

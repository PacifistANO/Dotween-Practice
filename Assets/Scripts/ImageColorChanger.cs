using DG.Tweening;
using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class ImageColorChanger : MonoBehaviour
{
    [SerializeField] private RawImage _rawImage;

    void Start()
    {
        _rawImage.DOColor(Color.green, 3).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}

using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Start()
    {
        Sequence textChangeSequence = DOTween.Sequence();
        textChangeSequence.Append(_text.DOText("яёниор", 2));
        textChangeSequence.Append(_text.DOText(" - Ўкола разработки игр", 5).SetRelative());
        textChangeSequence.Append(_text.DOText("яёниор - Ћучша€ школа разработки игр в –‘", 6, true, ScrambleMode.Lowercase));
        textChangeSequence.SetEase(Ease.Linear);
        textChangeSequence.SetLoops(-1, LoopType.Restart);
    }
}

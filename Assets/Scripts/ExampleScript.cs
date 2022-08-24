using DG.Tweening;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    private void Start()
    {
        RectTransform rect = (RectTransform)transform;

        Sequence sequence = DOTween.Sequence();
        sequence.Insert(0, rect.DORotate(Vector3.forward * 720, 6f, RotateMode.FastBeyond360));
        sequence.Insert(0, rect.DOAnchorPosX(200, 2f));
        sequence.Insert(2f, rect.DOAnchorPosX(-200, 2f).SetEase(Ease.InBack));
        sequence.Insert(4f, rect.DOAnchorPos(Vector3.zero, 2f).SetEase(Ease.OutBack));
        sequence.SetDelay(0.5f);
    }
}
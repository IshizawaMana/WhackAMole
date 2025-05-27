using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    private bool isVisible = false;
    private bool hasBeenHit = false;
    private Vector3 hiddenPosition;
    private Vector3 visiblePosition;
    private float showHeight = 1.0f; // �o�����̍���
    private float hideHeight = -0.5f; // �B��Ă鍂��

    void Start()
    {
        hiddenPosition = transform.localPosition;
        visiblePosition = new Vector3(hiddenPosition.x, showHeight, hiddenPosition.z);
        Hide(); // �ŏ��͉B��Ă���
    }

    public void Show()
    {
        isVisible = true;
        hasBeenHit = false;
        transform.localPosition = visiblePosition;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        isVisible = false;
        transform.localPosition = hiddenPosition;
        gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        if (isVisible && !hasBeenHit)
        {
            hasBeenHit = true;
            GameManager.Instance.AddScore(1);
            Hide();
        }
    }
}

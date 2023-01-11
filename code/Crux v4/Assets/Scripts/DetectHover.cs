using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DetectHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        ShowHover.OnHover();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        ShowHover.NoHover();
    }
    private void ShowMessage()
    {
        
    }
}

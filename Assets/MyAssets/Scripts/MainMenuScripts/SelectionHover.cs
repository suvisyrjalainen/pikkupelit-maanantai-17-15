using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionHover : MonoBehaviour,IPointerEnterHandler, IPointerClickHandler
{
    public Selector selector;
    public int index;
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}

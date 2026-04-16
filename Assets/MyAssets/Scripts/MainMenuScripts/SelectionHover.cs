using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionHover : MonoBehaviour,IPointerEnterHandler, IPointerClickHandler
{
    public Selector selector;
    public int index;
    public void OnPointerClick(PointerEventData eventData)
    {
        selector.ActivateItem(index);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        selector.SetIndex(index);
    }
}

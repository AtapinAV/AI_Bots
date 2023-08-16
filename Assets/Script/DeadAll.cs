using UnityEngine;
using UnityEngine.EventSystems;

public class DeadAll : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject [] _unit; 
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            foreach (var unit in _unit)
            {
                Destroy(unit);//dodo
            }
        }
             
    }
}

using UnityEngine;
using UnityEngine.EventSystems;

public class HealAll : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject[] _heal;
   
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.pointerId == -1)
        {
            foreach (var heal in _heal)
            {
                heal.SetActive(true);
            }
        }

        if (eventData.pointerId == -2)
        {
            foreach (var heal in _heal)
            {
                heal.SetActive(false);
            }
        }



    }
}

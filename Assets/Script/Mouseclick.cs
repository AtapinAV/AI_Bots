using UnityEngine;
using UnityEngine.EventSystems;

public class Mouseclick : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject _panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            _panel.SetActive(true);
        }
        /* if (eventData.pointerId == -2)
        {
            _panel.SetActive(false);
        }*/
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _panel.SetActive(false);
        }
    }
}

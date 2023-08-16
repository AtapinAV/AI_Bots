using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField, Range(1f, 100f)] private float _speedCamera = 5f;
    private void Update()
    {
        var ad = Input.GetAxis("Horizontal");
        if (ad != 0)
        {
            transform.position += _speedCamera * ad * Time.deltaTime * Vector3.right;
        }

        var ws = Input.GetAxis("Vertical");
        if (ws != 0)
        {
            transform.position += _speedCamera * Time.deltaTime * ws * Vector3.forward;
        }
    }
}

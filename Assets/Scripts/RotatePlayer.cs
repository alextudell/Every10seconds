using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    private Vector3 pos;

    [SerializeField]
    private Camera _camera;
    // Update is called once per frame
    void Update()
    {
        pos = _camera.WorldToScreenPoint(transform.position);
        Flip();
    }

    public void Flip()
    {
        // if (Input.mousePosition.x < pos.x)
        // {
        //     transform.localRotation = Quaternion.Euler(0, 180, 0);
        // } if (Input.mousePosition.x > pos.x)
        // {
        //     transform.localRotation = Quaternion.Euler(0, 0, 0);
        // }
        if (Input.mousePosition.y < pos.y)
        {
            transform.localRotation = Quaternion.Euler(180, 0, 0);
        } if (Input.mousePosition.y > pos.y)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform cam,target;
    public float speed;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, target.position, 0.5f * speed * Time.deltaTime);
        cam.position = pos;
    }
}


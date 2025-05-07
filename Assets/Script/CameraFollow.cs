using UnityEngine;

public class CameraFollowSimple : MonoBehaviour
{
    public Transform target;             // Objek (player) yang diikuti
    public Vector3 offset = new Vector3(0f, 10f, -5f);  // Jarak kamera dari player
    public float smoothSpeed = 5f;       // Kehalusan gerakan kamera

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
            // Tidak ada transform.LookAt -> tidak berputar
        }
    }
}

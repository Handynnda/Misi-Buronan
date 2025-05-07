using UnityEngine;

public class DrawerInteract : MonoBehaviour
{
    [Header("Positions")]
    public Transform openPosition;      // Posisi terbuka (Empty GameObject)
    public Transform closedPosition;    // Posisi tertutup (Empty GameObject)

    [Header("Settings")]
    public float moveSpeed = 2f;

    private bool isOpen = false;
    private bool playerNearby = false;

    void Update()
    {
        // Jika player dekat dan menekan tombol E, ubah status laci
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
        }

        // Tentukan target posisi tergantung status isOpen
        Transform target = isOpen ? openPosition : closedPosition;

        // Gerakkan laci secara halus ke posisi target
        transform.localPosition = Vector3.Lerp(transform.localPosition, target.localPosition, Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
        }
    }
}

using UnityEngine;

public class AutoOpenDoor : MonoBehaviour
{
    [SerializeField] private Animator doorAnimator;
    [SerializeField] private string openAnimName = "Open";
    [SerializeField] private string closeAnimName = "Close";
    [SerializeField] private bool isLocked = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isLocked)
        {
            doorAnimator.Play(openAnimName);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !isLocked)
        {
            doorAnimator.Play(closeAnimName);
        }
    }
}

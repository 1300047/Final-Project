using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DiscSnapAndPlay : MonoBehaviour
{
    public Transform snapPosition; // The exact position the disc should snap to
    public AudioSource gramophoneAudio;
    public float spinSpeed = 100f;
    
    private GameObject currentDisc;
    private bool isPlaying = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isPlaying || !other.CompareTag("Disc")) return;

        currentDisc = other.gameObject;

        // Lock disc position & rotation
        currentDisc.transform.position = snapPosition.position;
        currentDisc.transform.rotation = snapPosition.rotation;

        // Optional: make it child of snap point for better anchoring
        currentDisc.transform.SetParent(snapPosition);

        // Disable grabbing while in place
        var grabInteractable = currentDisc.GetComponent<XRGrabInteractable>();
        if (grabInteractable)
        {
            grabInteractable.enabled = false;
        }

        gramophoneAudio.Play();
        isPlaying = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == currentDisc)
        {
            gramophoneAudio.Stop();
            isPlaying = false;

            // Unparent and re-enable grabbing
            currentDisc.transform.SetParent(null);
            var grabInteractable = currentDisc.GetComponent<XRGrabInteractable>();
            if (grabInteractable)
            {
                grabInteractable.enabled = true;
            }

            currentDisc = null;
        }
    }

    private void Update()
    {
        if (isPlaying && currentDisc != null)
        {
            currentDisc.transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime, Space.Self);
        }
    }
}

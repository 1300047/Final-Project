using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(AudioSource), typeof(XRSocketInteractor))]
public class SocketAudioPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    private XRSocketInteractor socket;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        socket = GetComponent<XRSocketInteractor>();
    }

    private void OnEnable()
    {
        socket.selectEntered.AddListener(OnSelectEntered);
        socket.selectExited.AddListener(OnSelectExited);
    }

    private void OnDisable()
    {
        socket.selectEntered.RemoveListener(OnSelectEntered);
        socket.selectExited.RemoveListener(OnSelectExited);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    private void OnSelectExited(SelectExitEventArgs args)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour, IPointerDownHandler
{
    public AudioSource soundKoin;
    public void OnPointerDown(PointerEventData eventData)
    {
        soundKoin.PlayOneShot(soundKoin.clip);
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
}

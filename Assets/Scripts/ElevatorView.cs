using UnityEngine;
using JetBrains.Annotations;
using UnityEngine.UI;

public class ElevatorView : MonoBehaviour
{

    public Button UpButton;
    public Button DownButton;
    public AudioSource AudioSource;
    public AudioClip EvevatorGoesUpClip;
    public AudioClip EvevatorGoesDownClip;

    [UsedImplicitly]
    void OnEnable() {
	    UpButton.onClick.AddListener(() =>
	    {
	        Debug.Log("Up");
            AudioSource.PlayOneShot(EvevatorGoesUpClip);
	    });
        DownButton.onClick.AddListener(() =>
        {
            Debug.Log("Down");
            AudioSource.PlayOneShot(EvevatorGoesDownClip);
        });
    }

    [UsedImplicitly]
    void OnDisable()
    {
        UpButton.onClick.RemoveAllListeners();
        DownButton.onClick.RemoveAllListeners();
    }
}

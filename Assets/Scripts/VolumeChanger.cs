using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private UnityEngine.UI.Slider _slider;

    public void Change()
    {
        _audioMixer.audioMixer.SetFloat(_audioMixer.name, Mathf.Log10(_slider.value) * 40);
    }
}

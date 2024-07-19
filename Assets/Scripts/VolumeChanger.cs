using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(Change);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(Change);
    }

    public void Change(float value)
    {
        _audioMixer.audioMixer.SetFloat(_audioMixer.name, Mathf.Log10(_slider.value) * 40);
    }
}

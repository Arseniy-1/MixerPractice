using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ExtendedVolumeChanger : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioMixerGroup _audioMixer;
    [SerializeField] private Slider _slider;

    private bool _isEnabled = true;
    private float _minlVolume = -80;

    private void OnEnable()
    {
        _button.onClick.AddListener(ToggleMusic);
        _slider.onValueChanged.AddListener(Change);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ToggleMusic);
        _slider.onValueChanged.RemoveListener(Change);
    }

    public void ToggleMusic()
    {
        if (_isEnabled)
            _audioMixer.audioMixer.SetFloat(_audioMixer.name, _minlVolume);
        else
            SetCurrentVolume(_slider.value);

        _isEnabled = !_isEnabled;
    }

    private void Change(float amount)
    {
        if (_isEnabled)
            SetCurrentVolume(amount);
    }

    private void SetCurrentVolume(float volume)
    {
        _audioMixer.audioMixer.SetFloat(_audioMixer.name, Mathf.Log10(volume) * 40);
    }
}

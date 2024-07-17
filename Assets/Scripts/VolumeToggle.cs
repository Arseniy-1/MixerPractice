using UnityEngine;
using UnityEngine.Audio;

public class VolumeToggle : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixer;

    private bool isEnabled = true;

    public void ToggleMusic()
    {
        if (isEnabled)
            _audioMixer.audioMixer.SetFloat(_audioMixer.name, -80);
        else
            _audioMixer.audioMixer.SetFloat(_audioMixer.name, 0);

        isEnabled = !isEnabled;
    }
}

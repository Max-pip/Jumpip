
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;
    [SerializeField] private Image _soundOnIcon;
    [SerializeField] private Image _soundOffIcon;
    private bool _muted = true;


    public void OnButtonPress()
    {
        if (_muted == false)
        {
            _muted = true;
            _mixer.audioMixer.SetFloat("MasterVolume", 0);
        } else
        {
            _muted = false;
            _mixer.audioMixer.SetFloat("MasterVolume", 80);
        }     

        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (_muted == false)
        {
            _soundOnIcon.enabled = true;
            _soundOffIcon.enabled = false;
        } else
        {
            _soundOnIcon.enabled = false;
            _soundOffIcon.enabled = true;
        }
    }
}

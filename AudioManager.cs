using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // We have different AudioSources for music and sound effects, so we can control them separately
    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource sfxSource;

    // All audio files are of type 'AudioClip', no matter if music or sound effects
    [SerializeField] AudioClip forestBGM;

    [SerializeField] AudioClip piSFX;
    [SerializeField] AudioClip kaSFX;
    [SerializeField] AudioClip chuSFX;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // This will set the clip and interrupt the old one
            bgmSource.clip = forestBGM;
            bgmSource.Play();
        }

        // PlayOneShot on the other hand does not interrupt the current clip
        if (Input.GetKeyDown(KeyCode.Alpha2))
            sfxSource.PlayOneShot(piSFX);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            sfxSource.PlayOneShot(kaSFX);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            sfxSource.PlayOneShot(chuSFX);
    }
}

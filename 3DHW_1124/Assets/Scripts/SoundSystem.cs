using UnityEngine;
namespace yatzu
{
    /// <summary>
    /// 要求元件
    /// </summary>
    /// 要求元件:在第一次套用此腳本時會添加裡面指定的元件
    [RequireComponent(typeof(AudioSource))]
    public class SoundSystem : MonoBehaviour
    {
        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound)
        {
            aud.PlayOneShot(sound);
        }
    }
}
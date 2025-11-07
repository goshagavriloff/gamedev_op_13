using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsHelper : MonoBehaviour
{
    // Синглтон
    public static SoundEffectsHelper Instance;

    public AudioClip explosionSound2;
    public AudioClip playerShotSound;
    public AudioClip enemyShotSound;

    void Awake() {
        //  регистрируем синглтон
        if (Instance != null) {
            Debug.LogError("Несколько экземпляров SoundEffectsHelper");
        }
        Instance = this;
    }
    public void MakeExplosionSound() {
        MakeSound(explosionSound2);
    }

    public void MakePlayerShotSound() {
        MakeSound(playerShotSound);
    }
    public void MakeEnemyShotSound() {
        MakeSound(enemyShotSound);
    }

    // играть данный звук
    private void MakeSound(AudioClip originalClip)
    {
        // Поскольку это не 3д звук, его положение на сцене не имеет значение
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}

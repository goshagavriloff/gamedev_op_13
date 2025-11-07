using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Создание экземпляра частиц
public class SpecialEffectsHelper : MonoBehaviour
{
    // Синглтон
    public static SpecialEffectsHelper Instance;

    public ParticleSystem SmokeEffect;
    public ParticleSystem FireEffect;

    void Awake()
    {
        // регистрация синглтона
        if (Instance != null)
        {
            Debug.LogError("Несколько экземпляров SpecialEffectsHelper!");
        }
        Instance = this;
    }

    // Создать взрыв в данной точке
    public void Explosion(Vector3 position)
{
    // Дым над водой
    instantiate(SmokeEffect, position);

    // да-даам

    // Огонь в небе
    instantiate(FireEffect, position);
}

// Создание экземпляра системы частиц из префаба
private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
{
    ParticleSystem newParticleSystem = Instantiate(prefab, position, Quaternion.identity)
    as ParticleSystem;
    // Убедитесь, что это будет уничтожено
    float lifetime = newParticleSystem.main.startLifetime.constant;
    Destroy(newParticleSystem.gameObject, lifetime);

    return newParticleSystem;
}
}
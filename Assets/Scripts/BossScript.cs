using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
   private bool hasSpawn;

    // параметры компонентов
    private MoveScript moveScript;
    private WeaponScript[] weapons;
    private Animator animator;
    private SpriteRenderer[] renderers;

    // поведение босса (не совсем AI)
    public float minAttackCooldown = 0.5f;
    public float maxAttackCooldown = 2f;

    private float aiCooldown;
    private bool isAttacking;
    private Vector2 positionTarget;

    void Awake()
    {
        // Получить оружие только один раз
        weapons = GetComponentInChildren();

        // Отключить скрипты при отсутствии спауна
        moveScript = GetComponent();

        //Получить аниматор
        animator = GetComponent();

        // Получать рендеры в детях
        renderers = GetComponentInChildren();
    }

    void Start()
    {
        hasSpawn = false;

        // Отключить все
        collider2D.enabled = false;
        moveScript.enabled = false;
        foreach (WeaponScript weapon in weapons) {
            weapon.enabled = false;
        }
        // Дефолтное поведение
        isAttacking = false;
        aiCooldown = maxAttackCooldown;
    }
}

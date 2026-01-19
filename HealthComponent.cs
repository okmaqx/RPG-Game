using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private int hp = 100;
    [SerializeField] private int maxHp = 100;

    public void GetDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int healCount)
    {
        hp += healCount;
        if (hp > maxHp)
        {
            hp = maxHp;
        }
    }
}

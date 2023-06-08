public interface IHealth
{
    int CurrentHealth { get; }
    int MaxHealth { get; }

    void TakeDamage(int damageAmount);
    void Heal(int healAmount);
    void Die();
}
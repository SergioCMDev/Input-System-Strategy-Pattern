using UnityEngine;

namespace _InputTest.Scripts.Combat.Monobehaviours
{
    public class AttackableDebug : MonoBehaviour, IAttackable
    {
        public void OnAttacked(GameObject attacker, Attack attack)
        {
            Debug.Log($"Attacked by {attacker.name} for {attack.Damage.ToString()}, Critical is: {attack.Critical.ToString()}");
        }
    }
}
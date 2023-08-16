using UnityEngine;

[CreateAssetMenu(fileName = "baseConfigUnit", menuName = "Configurtion/ConfigUnit", order = 3)]
public class ConfigUnit : ScriptableObject
{
    [Tooltip("здоровье")]
    [SerializeField, Range(10f, 100f)]
    public float _heal;//todo
    [Tooltip("скорость перемещения")]
    [SerializeField, Range(1f, 100f)]
    public float _moveSpeed;//todo
    [Tooltip("урон от слабой атаки")]
    [SerializeField, Range(1f, 10f)]
    public float _weakDamage;//todo
    [Tooltip("урон от сильной атаки")]
    [SerializeField, Range(1f, 20f)]
    public float _strongDamage;//todo
    [Tooltip("швероятность промаха")]
    [SerializeField, Range(1f, 100f)]
    private float _miss;
    [Tooltip("шанс крита")]
    [SerializeField, Range(1f, 100f)]
    private float _critical;
    [Tooltip("вероятность сильной атаки")]
    [SerializeField, Range(1f,100f)]
    private float _probabilityStrong;
    [Tooltip("вероятность слабой атаки")]
    [SerializeField, Range(1f, 100f)]
    private float _probabilityWeak;

    public float GetHeal => _heal;
    public float GetMovespeed => _moveSpeed;
    public float GetWeakdamage => _weakDamage;
    public float GetStrongdamage => _strongDamage;
    public float GetMiss => _miss;
    public float GetCritical => _critical;
    public float GetProbabilityStrong => _probabilityStrong;
    public float GetProbabilityWeak => _probabilityWeak;

}

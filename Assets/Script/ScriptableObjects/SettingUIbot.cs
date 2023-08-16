using UnityEngine;

public class SettingUIbot : MonoBehaviour
{
    [SerializeField]
    private ConfigUnit _configUnit;
    
    public void HealUnit(float value)
    {
        _configUnit._heal = value;
    }

    public void SpeedUnit(float value)
    {
        _configUnit._moveSpeed = value;
    }

    public void WeakDamagUnit(float value)
    {
        _configUnit._weakDamage = value;
    }

    public void StrongDamagUnit(float value)
    {
        _configUnit._strongDamage = value;
    }      
}

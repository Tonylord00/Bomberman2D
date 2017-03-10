using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text m_Text;

    public void BtnPatate_OnClick()
    {
        m_Text.text = "Patate";
    }

    public void BtnToggle1_OnValueChange(bool aValue)
    {
        if (aValue == true)
        {
            m_Text.text = "patate1";
        }
    }

    public void BtnSlider_OnValueChange(float aValue) {
        Debug.Log("VALUE: " + aValue);
    }

    public void BtnToggle2_OnValueChange(bool aValue)
    {
        if (aValue == true)
        {
            m_Text.text = "patate2";
        }
    }

    public Slider m_HPSlider;

    private float m_MaxHP = 100;
    private float m_CurrentHP = 100;
    private float m_DamageValue = 10;

    public void BtnDegat_OnClick()
    {
        m_CurrentHP -= m_DamageValue;
        m_HPSlider.value = m_CurrentHP / m_MaxHP;
    }
}

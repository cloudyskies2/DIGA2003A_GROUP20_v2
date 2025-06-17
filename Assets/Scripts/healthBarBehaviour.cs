using UnityEngine;
<<<<<<< Updated upstream
using System.Collections;
using UnityEngine.UI;

public class healthBarBehaviour : MonoBehaviour
{
    public Slider slider;
    public Color low;
    public Color high;
    public Vector3 offset;

    public void SetHealth(float health, float maxHealth)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.value = health;
        slider.maxValue = maxHealth;

        slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(low, high, slider.normalizedValue);
=======
using UnityEngine.UI;
using System.Collections;

public class healthBarBehaviour : MonoBehaviour
{
    public Slider Slider;
    public Color Low;
    public Color High;
    public Vector3 Offset;

    public void setHealth(float health, float maxHealth)
    {
        Slider.gameObject.SetActive(health < maxHealth);
        Slider.value = health;
        Slider.maxValue = maxHealth;

        Slider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, Slider.normalizedValue);
>>>>>>> Stashed changes
    }

    void Update()
    {
<<<<<<< Updated upstream
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + offset);
=======
        Slider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
>>>>>>> Stashed changes
    }
}

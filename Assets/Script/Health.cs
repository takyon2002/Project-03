using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Image healthBar;
    [SerializeField] private Image backBar;

    [SeperatorAttibute()]
    [SerializeField] private float _maximumHeath;
    private float _currentHealth;
    private float lerpTimer;
    [SerializeField] private float _chipSpeed;
    [SerializeField] private float _damageDeal;
    [SerializeField] private AudioSource _hitSound;
    void Start()
    {
        _currentHealth = _maximumHeath;
    }

    // Update is called once per frame
    void Update()
    {
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maximumHeath);
        UpdateHealth();
        if (Input.GetKeyDown(KeyCode.K))
        {
            takenDamage(_damageDeal);
            Debug.Log(_currentHealth);

        }
    }
    public void UpdateHealth() {

        float fillF = healthBar.fillAmount;
        float fillB = backBar.fillAmount;
        float hFraction = _currentHealth / _maximumHeath;
        if (fillB > hFraction)
        {
            healthBar.fillAmount = hFraction;
            backBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / _chipSpeed;
            backBar.fillAmount = Mathf.Lerp(fillB, hFraction, percentComplete);
        }




    }
    public void takenDamage(float damage)
    {
        
        _currentHealth -= damage;
        lerpTimer = 0f;
        if(_hitSound != null)
        {
            AudioSource newSound = Instantiate(_hitSound, transform.position, Quaternion.identity);
            Destroy(newSound.gameObject, newSound.clip.length);
        }
        if(_currentHealth <= 0)
        {
            Destroy(gameObject);

        }
    }
}

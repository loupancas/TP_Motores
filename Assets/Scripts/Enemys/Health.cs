using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    
    [SerializeField]
    public int maxhealth;
    public int currentHealth;

    private void OnEnable()
    {
        currentHealth = maxhealth;

        
    }
    public void modifyHeatlh(int amount)
    {
        currentHealth += amount;
        float currentHealthp = (float)currentHealth / (float)maxhealth;
        

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            modifyHeatlh(-10);
    }
    


}

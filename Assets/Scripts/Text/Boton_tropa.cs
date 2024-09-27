using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_tropa : MonoBehaviour
{
    public int  costo;
    public GameObject tropaPrefab;
    public TowerEnemy towerenemy;
    public TowerHealth towerhealth;


    public void Start()
    {
        towerenemy = FindObjectOfType<TowerEnemy>();
        towerhealth = FindObjectOfType<TowerHealth>();
    }
    public void Update()
    {
        if (towerenemy.currentHealth <= 0 || towerhealth.currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        Oro adminOro = FindObjectOfType<Oro>();

        if (adminOro != null)
        {
            adminOro.ComprarTropa(costo, tropaPrefab);
        }
    }
}
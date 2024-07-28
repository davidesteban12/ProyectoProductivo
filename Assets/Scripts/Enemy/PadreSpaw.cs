using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadreSpaw : MonoBehaviour
{
    public GameObject[] spaw;
    public float seconds = 2f;
    public int maxActiveSpawns = 3; // Número máximo de spawns activos a la vez
    private float timer;
    private Queue<GameObject> activeSpawnsQueue;
    private Queue<GameObject> inactiveSpawnsQueue;

    void Start()
    {
        timer = seconds;
        activeSpawnsQueue = new Queue<GameObject>();
        inactiveSpawnsQueue = new Queue<GameObject>(spaw); // Inicializa la cola de spawns inactivos con todos los spawns

        // Asegúrate de que todos los spawns estén inicialmente desactivados
        foreach (GameObject spawn in spaw)
        {
            spawn.SetActive(false);
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        if (activeSpawnsQueue.Count < maxActiveSpawns && inactiveSpawnsQueue.Count > 0)
        {
            // Encuentra un spawn inactivo de la cola
            GameObject spawn = inactiveSpawnsQueue.Dequeue();
            if (spawn != null)
            {
                spawn.SetActive(true);
                activeSpawnsQueue.Enqueue(spawn);
                StartCoroutine(DeactivateSpawn(spawn));
            }
        }
        timer = seconds;
    }

    IEnumerator DeactivateSpawn(GameObject spawn)
    {
        yield return new WaitForSeconds(seconds);
        spawn.SetActive(false);
        activeSpawnsQueue.Dequeue();
        inactiveSpawnsQueue.Enqueue(spawn);
    }

    public void ActivateSpaw()
    {
        enabled = true;
    }

    public void DeactivateSpaw()
    {
        enabled = false;
    }
}


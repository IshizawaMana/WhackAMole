using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public Mole[] moles;
    public float spawnInterval = 1.0f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            int index = Random.Range(0, moles.Length);
            moles[index].Show();

            yield return new WaitForSeconds(0.75f);
            moles[index].Hide();
        }
    }
}

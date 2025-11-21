using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnItem : MonoBehaviour
{
    [SerializeField] GameObject[] itemPrefab;
    [SerializeField] float secondsSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnItems());
    }


    IEnumerator SpawnItems()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(itemPrefab[Random.Range(0, itemPrefab.Length)], 
            position, Quaternion.identity);

            yield return new WaitForSeconds(secondsSpawn);
           
        }
    }

}

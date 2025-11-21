using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : MonoBehaviour
{
    [field: SerializeField] protected int ItemsValue { get; set; }


    public abstract void Use(Player player);



    public void Pickup(Player player)
    {

        Use(player);
        Destroy(this.gameObject);

    }









    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

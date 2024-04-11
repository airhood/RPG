using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ItemStack
{
    public short itemID;
    public int amount;

    public ItemStack(short itemID, int amount)
    {
        this.itemID = itemID;
        this.amount = amount;
    }
}

public class InventoryData
{
    public short inventorySize;
    public List<ItemStack> slots = new List<ItemStack>();
}

public class Inventory : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

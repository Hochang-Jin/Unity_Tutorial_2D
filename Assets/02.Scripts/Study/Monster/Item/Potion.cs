using UnityEngine;

public class Potion : MonoBehaviour, IItem
{
    private Inventory inventory;
    public GameObject Obj { get; set; }
    private enum PotionType { HP, MP, Heart }
    [SerializeField] private PotionType potionType;
    
    private void OnMouseDown()
    {
        Get();
    }
    
    public void Get()
    {
        Debug.Log($"{this.name} 획득");
        gameObject.SetActive(false);
        inventory.AddItem(this);
    }
    private void Start()
    {
        Obj = gameObject;
        inventory = FindFirstObjectByType<Inventory>();
    }
}

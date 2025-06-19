using UnityEngine;

namespace MonsterInheritance
{
    public class Coin : MonoBehaviour, IItem
    {
        private Inventory inventory;
        public GameObject Obj { get; set; }
        private enum CoinType { GoldCoin, BlueCoin, PurpleCoin, GreenCoin }
        [SerializeField] private CoinType coinType;
        
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
}

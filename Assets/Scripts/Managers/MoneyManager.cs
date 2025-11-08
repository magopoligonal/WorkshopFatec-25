using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager Instance;
    public int money;

    private void Awake()
    {
        Instance = this;
    }
    
    public void AddMoney(int money)
    {
        this.money += money;
    }

}

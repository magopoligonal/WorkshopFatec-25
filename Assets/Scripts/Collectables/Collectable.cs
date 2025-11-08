using System.Dynamic;
using UnityEngine;
using UnityEngine.Events;
using System.Collections;


public class Collectable : MonoBehaviour
{
    public UnityEvent Collect;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Collect?.Invoke();
        MoneyManager.Instance.money++;
            StartCoroutine("Desative");
            
        }
    }

    public void Disable()
    {
        Invoke("Desativar", 5f);
    }

    public IEnumerable Desative()
    {   
        Debug.Log("Inicio a coroutine");
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
        Debug.Log("Terminou a coroutine");
    }

}

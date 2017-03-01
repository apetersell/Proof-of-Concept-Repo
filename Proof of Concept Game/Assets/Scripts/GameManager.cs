using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public GameObject gameInfo;

    private Dictionary<string, Ability.Type> toyAbilityDict;

    // Use this for initialization
    void Start () {

        CreateToyAbilityDict();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateToyAbilityDict()
    {
        toyAbilityDict = new Dictionary<string, Ability.Type>();

        toyAbilityDict.Add("Cat", Ability.Type.Shield);
        toyAbilityDict.Add("Dog", Ability.Type.Lunge);
        toyAbilityDict.Add("Kazoo", Ability.Type.Sing);
        toyAbilityDict.Add("Calculator", Ability.Type.Fireball);
    }

    void SetGameInfo()
    {
        GameInfo gi = gameInfo.GetComponent<GameInfo>();
        gi.player1Abilities = GetAbilityListFromToyList(player1.GetComponent<PlayerController>().playerToys);
        gi.player2Abilities = GetAbilityListFromToyList(player2.GetComponent<PlayerController>().playerToys);
    }

    List<Ability.Type> GetAbilityListFromToyList(List<string> toylist)
    {
        List<Ability.Type> abilityList = new List<Ability.Type>();
        foreach (string toy in toylist)
        {
            Ability.Type ability;
            toyAbilityDict.TryGetValue(toy, out ability);
            abilityList.Add(ability);
        }
        return abilityList;
    }

    public void AddShieldToList()
    {
        if(player1.GetComponent<PlayerController>().playerToys.Count == 0)
        {
            player1.GetComponent<PlayerController>().playerToys.Add("Cat");
        }
        if (player2.GetComponent<PlayerController>().playerToys.Count == 1)
        {
            player2.GetComponent<PlayerController>().playerToys.Add("Cat");
        }

    }

    public void AddLungeToList()
    {

        if (player1.GetComponent<PlayerController>().playerToys.Count == 0)
        {
            player1.GetComponent<PlayerController>().playerToys.Add("Dog");
        }
        if (player2.GetComponent<PlayerController>().playerToys.Count == 1)
        {
            player2.GetComponent<PlayerController>().playerToys.Add("Dog");
        }

    }

    public void AddFireballToList()
    {
        if (player1.GetComponent<PlayerController>().playerToys.Count == 0)
        {
            player1.GetComponent<PlayerController>().playerToys.Add("Calculator");
        }
        if (player2.GetComponent<PlayerController>().playerToys.Count == 1)
        {
            player2.GetComponent<PlayerController>().playerToys.Add("Calculator");
        }

    }

    public void AddSingToList()
    {
        if (player1.GetComponent<PlayerController>().playerToys.Count == 0)
        {
            player1.GetComponent<PlayerController>().playerToys.Add("Kazoo");
        }
        if (player2.GetComponent<PlayerController>().playerToys.Count == 1)
        {
            player2.GetComponent<PlayerController>().playerToys.Add("Kazoo");
        }

    }
}

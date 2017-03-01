using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public GameObject gameInfo;
    public List<string> playerToys;

    private Dictionary<string, Ability.Type> toyAbilityDict;

    // Use this for initialization
    void Start () {

        CreateToyAbilityDict();
        playerToys = new List<string>();

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
        playerToys.Add("Cat");
    }

    public void AddLungeToList()
    {
        playerToys.Add("Dog");
    }

    public void AddFireballToList()
    {
        playerToys.Add("Calculator");
    }

    public void AddSingToList()
    {
        playerToys.Add("Kazoo");
    }
}

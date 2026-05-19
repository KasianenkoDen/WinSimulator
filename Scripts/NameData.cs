using System;
using System.Collections.Generic;
using UnityEngine;

public class NameData : MonoBehaviour
{
    public string[] Trait_Inteligence = new string[4];
    public string[] Trait_SocialSkill = new string[4];
    public string[] Trait_Creativity = new string[4];
    public string txt1 = "Inteligence: ";
    public string txt2 = "Social Skill: ";
    public string txt3 = "Creativity: ";

    private void Start()
    {
        Trait_Inteligence[0] = "Stupid";
        Trait_Inteligence[1] = "Dumb";
        Trait_Inteligence[2] = "Avarage";
        Trait_Inteligence[3] = "Genius";

        Trait_SocialSkill[0] = "Unsocial";
        Trait_SocialSkill[1] = "Introvert";
        Trait_SocialSkill[2] = "Avarage";
        Trait_SocialSkill[3] = "Chud";

        Trait_Creativity[0] = "None";
        Trait_Creativity[1] = "Low";
        Trait_Creativity[2] = "Avarage";
        Trait_Creativity[3] = "High";
    }
}

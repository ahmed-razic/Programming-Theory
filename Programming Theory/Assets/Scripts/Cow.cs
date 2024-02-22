using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    private string animalName = "CowClassName";
    private string animalCall = "CowClassCall";
    private int animalAge = 15;

    public string AnimalName { get => animalName; set => animalName = value; }
    public string AnimalCall { get => animalCall; set => animalCall = value; }
    protected int AnimalAge { get => animalAge; set => animalAge = value; }

    public override string AbstractMethod()
    {
        return "Implementation of Abstract method in Cow";
    }

    // Start is called before the first frame update
    void Start()
    {
        AnimalMethod();
        AnimalName = "Cow";
        AnimalCall = "Moo";
        ChangeAndDisplayAge(25);
    }

    public override void AnimalSound()
    {
        Debug.Log(AnimalName + " sounds: " + AnimalCall);
    }

    private void ChangeAndDisplayAge(int age)
    {
        AnimalAge = age;
        Debug.Log("Animal age: " + AnimalAge);
    }


    // Update is called once per frame
    void Update()
    {

    }
}

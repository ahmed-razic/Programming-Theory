using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : Animal
{
    private string animalName = "SheepClassName";
    private string animalCall = "SheepClassCall";
    private int animalAge = 11;

    public string AnimalName { get => animalName; set => animalName = value; }
    public string AnimalCall { get => animalCall; set => animalCall = value; }
    protected int AnimalAge { get => animalAge; set => animalAge = value; }

    public override string AbstractMethod()
    {
        return "Implementation of Abstract method in Sheep";
    }

    // Start is called before the first frame update
    void Start()
    {
        AnimalMethod();
        AnimalName = "Sheep";
        AnimalCall = "Me-eee";
        ChangeAndDisplayAge(13);
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

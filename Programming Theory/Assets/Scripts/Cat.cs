using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private string animalName = "CatClassName";
    private string animalCall = "CatClassCall";
    private int animalAge = 5;

    public string AnimalName { get => animalName; set => animalName = value; }
    public string AnimalCall { get => animalCall; set => animalCall = value; }
    protected int AnimalAge { get => animalAge; set => animalAge = value; }

    public override string AbstractMethod()
    {
        return "Implementation of Abstract method in Cat";
    }
    
    // Start is called before the first frame update
    void Start()
    {
        AnimalMethod();
        AnimalName = "Cat";
        AnimalCall = "Meow";
        ChangeAndDisplayAge(5);
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

class Author{

public string name;
public int age;
public string nationality;


public Author()
{
    
}
public Author(string a,int b)
{
    name=a;
    age=b;
    
}
public Author(string a,int b,string c)
{
    name=a;
    age=b;
    nationality=c;
    
}

public string GetName(){

    return name;
}
public string  GetNationality(){

    return nationality;
}
public int GetAge(){

    return age;
}
 public void Introduce (){

 System.Console.WriteLine($"Меня зовут {name}.Мне {age} лет. Я из {nationality}");


 }
 public void CelebrateBirthday(){

    age++;
 }




}
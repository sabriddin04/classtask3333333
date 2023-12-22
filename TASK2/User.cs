class User{


public string FirstName;

public string LastName;

public string UserName;

public string Password;
 public bool IsLoggedIn ;


public void Login(){
  
  if(FirstName==UserName && Password=="sabrik2004"){

    System.Console.WriteLine("Пользователь успешно зарегистрирован");
    IsLoggedIn=true;

  }
  else{
    System.Console.WriteLine("Ваш пароль или имя пользователя неверны.");
    IsLoggedIn=false;
  }

}
public void LogOut(){

IsLoggedIn=false;



}
public string GEtFullInfo(){

    return $"{FirstName} {LastName}-{IsLoggedIn}";
}



}
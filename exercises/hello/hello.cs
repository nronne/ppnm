using System;

public class User{
       public string Name{
       	      get;
       }
       public User(){
              Name = Environment.UserName;
       }
}

public class Hello{
	static void Main(){
	        User myUser = new User();
		string myUserName = myUser.Name;
		Console.Write("Hello {0}\n", myUserName);
	}
}
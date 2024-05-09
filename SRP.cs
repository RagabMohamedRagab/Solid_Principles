// SRP = > Single Resposibility Principle
// A class Or Module Must has one reson for Change and have only one Responsibility.

using System;
namespace SRP
{
  public class User{
     public void Add(string obj){};
     public void SendMessageEmail(int Id){};
  }
  // This class has two Responsiblity first add User second Send Message for User at Email.

  // Applied SRP

  public class AddUser{
      public void Add(string obj){};
  }

  public class SendMessage{
    public void SendMessageEmail(int Id){};
  }
}
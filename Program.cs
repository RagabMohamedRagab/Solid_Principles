// SRP = > Single Resposibility Principle
// A class Or Module Must has one reson for Change and have only one Responsibility.

using System;
using OCP.
using SRP;
namespace SRP
{
  public class Program{
     private static void Main(string []args){
         User obj=new;
         obj.Add("Ahmed");
         obj.SendMessageEmail("Has You GirlFriend");
         // Applied SRP : Seperated Class Into two class.
          AddUser u1=new;
          u1.Add("Ahmed");
          SendMessage sm=new;
          sm.SendMessageEmail("Good");
          // Applied OCP : Open For Extension And Closed For Modifactions.

        Shap shap=new Rectangle(); 
          shap.DrawShap();
 
          Shap shap=new  Circle();
        shap.DrawShap();

     }
  }    
}
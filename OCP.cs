// OPen Closed Principle (OCP) => Class must Open For Extention  but Closed For Modifications;
// To Achive This Principle Must Known Abstractions And PolymorePhisim.
using System;
namespace OCP{
    
    public class Rectangle:Shap{
         protected int Width;
         protected int Height;
         public override void DrawShap(){
            // Draw Shape 
         }
    }

    public class Circle:Shap{
        protected int Radius;
        public override void DrawShap(){
            // Draw Shape 
         }
    }
    // If I need To Add Functions 

    abstract class Shap{
        public virtual void DrawShap(){
        }
    }

}
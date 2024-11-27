using System.Numerics;
using StructuralDesignPatterns.Composite;

var package = new Box();

var box1 = new Box();
box1.Add(new Microphone());

var box2 = new Box();

var box3 = new Box();
box3.Add(new Mouse());

var box4 = new Box();
box4.Add(new Keyboard());

box2.Add(box3);
box2.Add(box4);

package.Add(box1);
package.Add(box2);

System.Console.WriteLine("TotalPrice is : " + package.GetPrice());
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineOrdering{
    //Declare delegate to get Order status 
    public  delegate void Delegate_Use(int status);
public class OrderStatus
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("C# Assignment");
        Console.WriteLine ("");
        Console.WriteLine ("Select the items from Menu");
        Console.WriteLine ("");
        Console.WriteLine ("1.Burger");
        Console.WriteLine ("");
        Console.WriteLine ("2.Pizza");
        Console.WriteLine ("");
        Console.WriteLine ("3.Fries");
        Console.WriteLine ("");
        Console.WriteLine ("4.Coke");
        Console.WriteLine ("");
        Console.WriteLine ("5.Combo Meal");
        Console.WriteLine ("");
        Console.WriteLine ("6.Sandwich");
        Console.WriteLine ("");
        int itemId =Convert.ToInt32(Console.ReadLine());
        if(itemId>6){
            Console.WriteLine ("Select valid Items");
        }else{
        OrderStatusOfFood statusRef=new OrderStatusOfFood();
        statusRef.GetOrderStatus(Status);
        }
        Console.ReadLine();
        
    }
    //The various statuses of food when ordered online
    public  static void Status(int x){
        switch(x){
            case 1:Console.WriteLine ("Added to cart");
                break;
            case 2:Console.WriteLine ("Order confirmed");
                break;
            case 3:Console.WriteLine ("Preparing the Food");
                break;
            case 4:Console.WriteLine ("Delivery partner assigned");
                break;
            case 5:Console.WriteLine ("Order picked up");
                break;
            case 6:Console.WriteLine ("Order Delivered");
                break;
            default:Console.WriteLine ("Order Cancelled");
                break;
            
        }
    }
}
class OrderStatusOfFood{
    public void GetOrderStatus(Delegate_Use statusRef){
        //With delay of 1sec get the status of order
        for(int i=1;i<=6;i++){
            Thread.Sleep(1000);
            int status=i;
            statusRef(status);
        }
    }
    
    
}
}
/*
Create a command-line shopping cart application. Your application should
support adding items, removing items, and calculating the total price with
possible discounts. Use the Strategy pattern for the discount calculation 
and demonstrate how this pattern makes your application more flexible.
*/

using System;
using System.Collections;

interface Discounts{
    public double Discount(int price);
}

class SeasonalDiscount : Discounts{
    private double perc_disc = 40;
    private void SeasonDiscount(){
        Console.WriteLine("Seasonal Discount");
    }
    public double Discount(int price){
        Console.WriteLine(price);
        return ((perc_disc/100)*price);
    }
    public void Discountprice(int price){
        SeasonDiscount();
        Console.WriteLine(price);
        Console.WriteLine($"final price after discount is {Discount(price)}");
    }
}

class FestivalDiscount : Discounts{
    private double perc_disc = 80;
    public void FestDiscount(){
        Console.WriteLine("FestivalDiscount");
    }
    public double Discount(int price){
        return ((perc_disc/100)*price);
    }
    public void Discountprice(int price){
        FestDiscount();
        Console.WriteLine($"final price after discount is {Discount(price)}");
    }
}

class BulkDiscount : Discounts{
    private double perc_disc = 60;
    public void BuDiscount(){
        Console.WriteLine("BulkDiscount");
    }
    public double Discount(int price){
        return ((perc_disc/100)*price);
    }
    public void Discountprice(int price){
        BuDiscount();
        Console.WriteLine($"final price after discount is {Discount(price)}");
    }
}

class Calculate_item_cost {

    private Discounts _discount_type;

    public Calculate_item_cost (Discounts discount_type){
        _discount_type = discount_type;
    }

    static Dictionary<string ,int> Create_Items(){
        Dictionary <string, int> items = new Dictionary<string, int>(); 
        items.Add("Milk",33);
        items.Add("Bread",55);
        items.Add("Butter",105);
        items.Add("Rajma",120);
        items.Add("onion",40);

        return items;
    }

    private List<int> Add_items(List<string> list){

        Dictionary<string, int> items = Create_Items();
        List<int> item_cost = new List<int>();

        foreach (var item in list)
        {
            if (items.ContainsKey(item)){
                Console.WriteLine($"Item found {item}");
                item_cost.Add(items[item]);
            }
            else
            {
                Console.WriteLine($"Item not found {item}");
            }
        }
        
        return item_cost;
    }

    public int FinalCost(List<string> list){
        List<int> item_cost = Add_items(list);
        
        int sum = 0;
        sum = item_cost.Sum();
        sum = sum - (int)_discount_type.Discount(sum);
        
        return sum;
    }
}

class Problem8{
    // static void Main(string[] args){
    //     List<String> Items = new List<string>();
    //     Console.WriteLine("Enter the discount right now from 1,2,3");
    //     int Discounttype = Convert.ToInt32(Console.ReadLine());
    //     string input = Console.ReadLine();
    //     Items = input.Split().ToList();

    //     Discounts discountstrat = Discounttype switch
    //     {
    //         1 => new SeasonalDiscount(),
    //         2 => new FestivalDiscount(),
    //         3 => new BulkDiscount(),
    //         _ => throw new Exception("This is not a valid discount type") 
    //     };

    //     var cart = new Calculate_item_cost(discountstrat);
    //     int totalCost = cart.FinalCost(Items);

    //     Console.WriteLine($"Total cost after discount: {totalCost}");
    // }
}


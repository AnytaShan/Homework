public class Car
{
    private string make;  // private - доступ только внутри класса Car
    private string model;
    public int year { get; set; }  // public - доступ из любого места
    internal void setMakeAndModel(string make, string model)  // Internal метод - доступен в пределах текущей сборки
    {
        this.make = make;
        this.model = model;
    }
    protected virtual void DisplayInfo()  //Protected метод - доступен в этом классе и производных классах
    {
        Console.WriteLine($"Марка: {make}");
        Console.WriteLine($"Модель: {model}");
        Console.WriteLine($"Год выпуска: {year}");
    }
}

public class ElectricCar : Car  // Класс ElectricCar наследует Car и добавляет функциональность батареи
{
    private double batteryCapacity;
    public void SetBatteryCapacity(double batteryCapacity) 
    {
        this.batteryCapacity = batteryCapacity;
    }
    protected override void DisplayInfo()  // Переопределенный protected метод - доступен в этом классе и производных классах
    {
        base.DisplayInfo();
        Console.WriteLine($"Ёмкость: {batteryCapacity}");
    }
}

namespace MyApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.model = "BMW";
            car.make = "трактор";  // Попытка установить make и model напрямую (запрещено, так как поля private)
            car.setMakeAndModel("BMW", "трактор");  // internal метод из базового класс

            var electricCar = new ElectricCar();  
            electricCar.SetBatteryCapacity(100.0);  // public метод ElectricCar

            car.DisplayInfo();  // Для базового Car нет public метода для вызова DisplayInfo, поэтому информация не отобразится
            electricCar.DisplayInfo();
        }
    }
}
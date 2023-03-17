// See https://aka.ms/new-console-template for more information
using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data) {
        this.data = data;
    }

    public void PrintData() {
        Console.WriteLine("Data yang tersimpan adalah: " + data.ToString());
    }
}

class Program
{
    static void Main(string[] args) {
        DataGeneric<int> data = new DataGeneric<int>(1302210046);
        data.PrintData();
    }
} 

using System;
using VetorExeFixacao;

public class Program {
    public static void Main(string[] args) {

        Room[] rooms = new Room[10];

        Console.Write("Quantos quartos serão alugados? ");
        int qtyRoomsRent = int.Parse(Console.ReadLine());

        for(int i = 0; i < qtyRoomsRent; i++) {
            Console.WriteLine("Aluguel #", i + 1);
            Console.Write("Nome: ");
            string nameStudent = Console.ReadLine();
            Console.Write("Email: ");
            string emailStudent = Console.ReadLine();
            Console.Write("Quarto: ");
            int numberRoom = int.Parse(Console.ReadLine());
            Console.WriteLine();

            rooms[numberRoom] = new Room {NameStudent = nameStudent, EmailStudent = emailStudent};
        }

        Console.WriteLine("Quartos ocupados:");
        for(int i = 0; i < 10; i++) {
            if(rooms[i] != null) {
                Console.WriteLine(i + ": " + rooms[i]);
            }
        }
    }
}
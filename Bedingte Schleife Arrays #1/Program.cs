using System.Reflection.Metadata.Ecma335;

int num1;
string eingabe;
int arraycounter = 0;
string[] monate = { "januar", "februar", "märz", "april", "mai", "juni", "juli", "august", "september", "oktober", "november", "dezember" };
string[] months = { "january", "febuary", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
void übersetzungsnummer()
{
    if (num1 == 1)
    {
        if (eingabe == monate[arraycounter])
        {
            Console.WriteLine(months[arraycounter].ToString());
            arraycounter = 0;

        }
        else
        {

            arraycounter = arraycounter + 1;
            übersetzungsnummer();
        }
    }
    else if(num1 == 2)
    {
        if (eingabe == monate[arraycounter])
        {
            Console.WriteLine((arraycounter + 1).ToString());
            arraycounter = 0;

        }
        else
        {

            arraycounter = arraycounter + 1;
            übersetzungsnummer();
        }

    }
}
    while (true)
    {
        Console.WriteLine("Wünschen sie eine Übersetzung, oder Monatsnummer?");
        Console.WriteLine("(1) Übersetzung      (2) Monatsnummer");

        num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 == 1)
        {
            Console.WriteLine("Geben sie bitte einen der folgenden Monate ein");
            foreach (var item in monate)
            {
                Console.WriteLine(item.ToString());
            }
        eingabe = Console.ReadLine();
        übersetzungsnummer();
        }
        else if (num1 == 2)
        {
            Console.WriteLine("Geben sie bitte einen Monat ein");
            foreach (var item in monate)
            {
                Console.WriteLine(item.ToString());
            }
        eingabe = Console.ReadLine();
        übersetzungsnummer();
    }
        else
        {
            Console.WriteLine("Bitte geben sie entweder 1 oder 2 ein");
        }
    }


using AddressList;
StreamReader file = File.OpenText("C:/Users/generation/Downloads/addresses.csv");
List<AddressList> Adresses = new List<AddressList>();

int readedString = 0;

while (!file.EndOfStream)
{
    readedString++;
    string line = file.ReadLine();

    if (readedString == 1)
    {
        continue;
    }

    string[] dateInString = line.Split(',');
    for (int i = 0; i < dateInString.Length; i++)
    {
        if (dateInString[i] == "")
        {
            dateInString[i] = "Undefined";
        }
    }

    if (readedString.Length == 6)
    {
        AddressList Address = new AddressList(readedString[0], readedString[1], readedString[2], readedString[3], readedString[4], readedString[5]);

        Address.Add(Address);
    }
    else if (readedString.Length == 7)
    {
        AddressList Address = new AddressList(readedString[0] + " " + readedString[1], readedString[2], readedString[3], readedString[4], readedString[5], readedString[6]);

        AddressList.Add(Address);
    }

}file.Close();

foreach (AddressList address in AddressList)
{
    Console.WriteLine(address);
}
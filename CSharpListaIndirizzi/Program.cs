
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


}
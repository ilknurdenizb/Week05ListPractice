List<string> partyMembers = new List<string>(); // List to hold party members
partyMembers.Add("Bülent Ersoy"); // Adding members to the party
partyMembers.Add("Ajda Pekkan");
partyMembers.Add("Ebru Gündeş");
partyMembers.Add("Hadise");
partyMembers.Add("Hande Yener");
partyMembers.Add("Tarkan");
partyMembers.Add("Funda Arar");
partyMembers.Add("Demet Akalın");
Console.WriteLine("** Davetliler **");
for (int i = 0; i < partyMembers.Count; i++) // Loop through the list of party members
{
    
    Console.WriteLine($"{i + 1} - {partyMembers[i]}"); // Display each member with their index
}

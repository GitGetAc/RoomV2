namespace RoomV2
{
    internal class Program
    {
        static void Main()
        {
            House house = new();

            house.BuildAHouse();
            house.PrintOutHouse();
        }
    }
}

/*/*Lag en app som kan bygge et hus. Et hus kan bestå av etasjer og rom. 
 * 
 * Floor: Brukeren skal kunne velge hva slags type rom den vil legge til om det er bad, kjøkken, soverom eller stue.  og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje. 
 * 
 * HUS: Når huset er ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.
 Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom,*/
// See https://aka.ms/new-console-template for more information

//SNACK 1

//1. chiediamo all'utente se vuole criptare o decriptare un testo
Console.WriteLine("Vuoi Crypatare un testo?");
bool TrueFalse = Console.ReadLine() == "True";

//2. chiedete una chiave numero da 1 a 10
Console.WriteLine("Inserisci un numero da 1 a 10");
int NumeroUtente = Convert.ToString(NumeroUtente);

//3. chiede di inserire il testo da criptare/decriptare
Console.WriteLine("Inserisci un testo da cryptare");
var TestoUtente = Console.ReadLine();

//4. il sistema effettua la criptazione
var TestoCryptato = Convert.ToChar(NumeroUtente + TestoUtente);

//5. il sistema mostra a video il testo criptato
Console.WriteLine("Questo è il testo cryptato" + TestoCryptato);

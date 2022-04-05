// See https://aka.ms/new-console-template for more information

/* Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
- Titolo
- Autore
- ISBN
- Numero pagine
- Peso del libro
- Larghezza, Altezza e Profondità del libro
- Valutazione media
- Numero di recensioni
- se è disponibile in versione Kindle
- se la copertina flessibile è disponibile
*/

// INIZIO ESERCIZIO INFO GENERICHE 

string titolo = "La partita della vita";
string autore = "Sinisa Mihalovic";
string isbn = "978-88-282-0501-2";
int numeroPagine = 456;
int peso = 580;

double larghezza = 15;
double altezza = 22.3;
double profondità = 3.5;

double valutazioneMedia = 4.5;
int numeroRecensioni = 262;

bool versioneKindle = true;
bool copertinaFlessibile = false;


// Stampare in console tutte le informazioni 

Console.WriteLine("Il libro che vi consiglio di leggere è " + titolo + " scritto da " + autore);
Console.WriteLine("Le dimensioni di questo libro sono:" + " Larghezza = " + larghezza + " cm " + " Altezza = " + altezza + " cm "+ " Profondità = " + profondità + " cm " + " ed ha un peso di " + peso + " grammi ");
Console.WriteLine("Il libro è formato da " + numeroPagine + " pagine ");
Console.WriteLine("Le recensioni ricevute sono " + numeroRecensioni + " con una media di " + valutazioneMedia + " stelline ");
Console.WriteLine("L'ISBN di questo libro è " + isbn);
Console.WriteLine("La versione Kindle è disponibile ? " + versioneKindle);
Console.WriteLine("La copertina flessibile è disponibile ? " + copertinaFlessibile);
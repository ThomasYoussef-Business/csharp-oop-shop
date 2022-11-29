/*
 * Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
 * Un prodotto è caratterizzato da:
 *  [x] codice (numero intero)
 *  [x] nome
 *  [x] descrizione
 *  [x] prezzo
 *  [x] iva
 * 
 * Usate opportunamente i livelli di accesso (public, private), i costruttori,
 * i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
 *  [x] alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
 *  [x] Il codice prodotto sia accessibile solo in lettura
 *  [x] Gli altri attributi siano accessibili sia in lettura che in scrittura
 *  [x] Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.
 *  [x] Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
 *
 * Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci con loro per testare tutti i metodi che avete previsto e implementato.
 */

using CSharpShop;

Prodotto maionese = new Prodotto("Maionese", "Un barattolo di maionese", 5.99, 0.052);
Console.WriteLine($@"{maionese.Nome} [{maionese.NomeEsteto}]:
{maionese.Descrizione}
EUR {maionese.PrezzoConIva}
IVA {maionese.Iva}");
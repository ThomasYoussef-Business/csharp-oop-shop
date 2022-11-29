namespace CSharpShop {
    public class Prodotto {
        public string Codice { get; init; }
        public string Nome { get; set; }
        public string NomeEsteto => Codice + Nome;
        public string Descrizione { get; set; }
        private float prezzoBase;
        public float PrezzoBase {
            get => prezzoBase;
            set {
                if (value is < 0) {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} non può essere meno di zero");
                }
                prezzoBase = value;
            }
        }
        private float iva;
        public float Iva {
            get => iva;
            set {
                if (value is < 0 or > 1) {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} deve essere tra 0 e 1");
                }
            }
        }
        public float PrezzoConIva => PrezzoBase * Iva;

        public Prodotto(string nome, string descrizione, float prezzoBase, float iva) {
            Codice = new Random().Next(1, 100_000_000).ToString(); // Valori casuali da 1 a 99,999,999
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), $"{nameof(nome)} non può essere nullo");
            Descrizione = descrizione ?? throw new ArgumentNullException(nameof(descrizione), $"{nameof(descrizione)} non può essere nullo");
            PrezzoBase = prezzoBase;
            Iva = iva;
        }
    }
}

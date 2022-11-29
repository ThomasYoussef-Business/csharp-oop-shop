namespace CSharpShop {
    public class Prodotto {
        public string Codice { get; init; }
        public string Nome { get; set; }
        public string NomeEsteto { get => Codice + Nome; }
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
        public float PrezzoConIva { get => (PrezzoBase * Iva); }

        public Prodotto(string codice, string nome, string descrizione, float prezzoBase, float iva) {
            Codice = codice ?? throw new ArgumentNullException(nameof(codice), $"{nameof(codice)} non può essere nullo");
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), $"{nameof(nome)} non può essere nullo");
            Descrizione = descrizione ?? throw new ArgumentNullException(nameof(descrizione), $"{nameof(descrizione)} non può essere nullo");
            PrezzoBase = prezzoBase;
            Iva = iva;
        }
    }
}

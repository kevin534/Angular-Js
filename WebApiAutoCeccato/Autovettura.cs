using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutoCeccato
{
    public class Autovettura
    {

        public int ID { get; set; }

        public string Telaio { get; set; }
        public string Targa { get; set; }
        public string TipoAuto { get; set; }
        public AnagraficaVeicolo AnagraficaVeicolo { get; set; }
        public RitiroPrezzi RitiroPrezzi { get; set; }
        public FatturazioneConformita FatturazioneConformita { get; set; }
        public PrenotazioneVenditaConsegna PrenotazioneVenditaConsegna { get; set; }
        public StatusTrasportoDocumenti StatusTrasportoDocumenti { get; set; }

        public Autovettura()
        {

        }

        public Autovettura(int ID, string Telaio, string Targa, string TipoAuto, AnagraficaVeicolo AnagraficaVeicolo,
            RitiroPrezzi RitiroPrezzi, FatturazioneConformita FatturazioneConformita, PrenotazioneVenditaConsegna PrenotazioneVenditaConsegna, StatusTrasportoDocumenti StatusTrasportoDocumenti)
        {
            this.ID = ID;
            this.Telaio = Telaio;
            this.Targa = Targa;
            this.TipoAuto = TipoAuto;
            this.AnagraficaVeicolo = AnagraficaVeicolo;
            this.RitiroPrezzi = RitiroPrezzi;
            this.FatturazioneConformita = FatturazioneConformita;
            this.PrenotazioneVenditaConsegna = PrenotazioneVenditaConsegna;
            this.StatusTrasportoDocumenti = StatusTrasportoDocumenti;


        }
    }


    public class AnagraficaVeicolo
    {
        public Marca Marca { get; set; }
        public Modello Modello { get; set; }
        public Versione Versione { get; set; }
        public string Statut { get; set; }
        public string Descrizione { get; set; }
        public DatiVeicolo DatiVeicolo { get; set; }
        public Optionals Optionals { get; set; }
        public PrezzoVendita PrezzoVendita { get; set; }

        public AnagraficaVeicolo() { }

        public AnagraficaVeicolo(Marca Marca, Modello Modello, Versione Versione, string Statut, string Descrizione, DatiVeicolo DatiVeicolo,
            Optionals Optionals, PrezzoVendita PrezzoVendita)
        {
            this.Marca = Marca;
            this.Modello = Modello;
            this.Versione = Versione;
            this.Statut = Statut;
            this.Descrizione = Descrizione;
            this.DatiVeicolo = DatiVeicolo;
            this.Optionals = Optionals;
            this.PrezzoVendita = PrezzoVendita;
        }

    }

    public class Marca
    {
        public int Codice { get; set; }
        public string Valore { get; set; }

        public Marca() { }

        public Marca(int Codice, string Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;
        }

    }

    public class Modello
    {
        public int Codice { get; set; }
        public int Valore { get; set; }

        public Modello() { }

        public Modello(int Codice, int Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;

        }
    }
    public class Versione
    {
        public int Codice { get; set; }
        public string Valore { get; set; }

        public Versione() { }

        public Versione(int Codice, string Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;
        }
    }
    public class DatiVeicolo
    {
        public string TipoVeicolo { get; set; }
        public string Omologazione { get; set; }
        public Double Cilindrata { get; set; }
        public Double KmPercorsi { get; set; }
        public DateTime ScadenzaBollo { get; set; }
        public string Alimentazione { get; set; }
        public string Trazione { get; set; }
        public Double PotenzaKW { get; set; }
        public DateTime PrimImmatricolazione { get; set; }
        public string Carrozzeria { get; set; }
        public int Cavalli { get; set; }
        public int NumeroPosti { get; set; }
        public Colore Colore { get; set; }
        public string Linea { get; set; }
        public string Ubicazione { get; set; }
        public UbicazioneAttuale UbicazioneAttuale { get; set; }

        public string DestinatoVendita { get; set; }
        public Double PremioAgente { get; set; }

        public DatiVeicolo() { }

        public DatiVeicolo(string TipoVeicolo, string Omologazione, Double Cilindrata, Double KmPercorsi, DateTime ScadenzaBollo, string Alimentazione,
          string Trazione, Double PotenzaKW, DateTime PrimImmatricolazione, string Carrozzeria, int Cavalli, int NumeroPosti, Colore Colore, string Linea,
          string Ubicazione, UbicazioneAttuale UbicazioneAttuale, string DestinatoVendita, Double PremioAgente)
        {
            this.TipoVeicolo = TipoVeicolo;
            this.Omologazione = Omologazione;
            this.Cilindrata = Cilindrata;
            this.KmPercorsi = KmPercorsi;
            this.ScadenzaBollo = ScadenzaBollo;
            this.Alimentazione = Alimentazione;
            this.Trazione = Trazione;
            this.PotenzaKW = PotenzaKW;
            this.PrimImmatricolazione = PrimImmatricolazione;
            this.Carrozzeria = Carrozzeria;
            this.Cavalli = Cavalli;
            this.NumeroPosti = NumeroPosti;
            this.Colore = Colore;
            this.Linea = Linea;
            this.Ubicazione = Ubicazione;
            this.UbicazioneAttuale = UbicazioneAttuale;
            this.DestinatoVendita = DestinatoVendita;
            this.PremioAgente = PremioAgente;


        }





    }
    public class Colore
    {
        public int Codice { get; set; }
        public string Valore { get; set; }

        public Colore()
        {

        }
        public Colore(int Codice, string Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;
        }

    }
    public class UbicazioneAttuale
    {
        public string Codice { get; set; }
        public string Valore { get; set; }

        public UbicazioneAttuale()
        {

        }
        public UbicazioneAttuale(string Codice, string Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;
        }
    }
    public class Optionals
    {
        public Double Totale { get; set; }
        public Double TotaleIva { get; set; }
        public List<OptionalItem> ListaOptionals { get; set; }

        public Optionals() { }
        public Optionals(Double Totale, Double TotaleIva, List<OptionalItem> ListaOptionals)
        {
            this.Totale = Totale;
            this.TotaleIva = TotaleIva;
            this.ListaOptionals = ListaOptionals;
        }

    }


    public class OptionalItem
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }
        public string SerieRichiesto { get; set; }
        public Double Prezzo { get; set; }
        public Double PrezzoIva { get; set; }
        public char Pack { get; set; }
        public OptionalItem() { }

        public OptionalItem(string Codice, string Descrizione, string SerieRichiesto, Double Prezzo, Double PrezzoIva, char Pack)
        {
            this.Codice = Codice;
            this.Descrizione = Descrizione;
            this.SerieRichiesto = SerieRichiesto;
            this.Prezzo = Prezzo;
            this.PrezzoIva = PrezzoIva;
            this.Pack = Pack;
        }





    }
    public class PrezzoVendita
    {
        public PrezzoVeicolo PrezzoVeicolo { get; set; }
        public PrezzoOptionals PrezzoOptionals { get; set; }
        public Totale Totale { get; set; }
        public ListinoBase ListinoBase { get; set; }

        public PrezzoVendita() { }

        public PrezzoVendita(PrezzoVeicolo PrezzoVeicolo, PrezzoOptionals PrezzoOptionals, Totale Totale, ListinoBase ListinoBase)
        {
            this.PrezzoVeicolo = PrezzoVeicolo;
            this.PrezzoOptionals = PrezzoOptionals;
            this.Totale = Totale;
            this.ListinoBase = ListinoBase;
        }


    }
    public class PrezzoVeicolo
    {
        public Double Valore { get; set; }
        public Double Ass { get; set; }

        public PrezzoVeicolo() { }

        public PrezzoVeicolo(Double Valore, Double Ass)
        {
            this.Valore = Valore;
            this.Ass = Ass;
        }
    }
    public class PrezzoOptionals
    {
        public Double Valore { get; set; }
        public Double Ass { get; set; }
        public PrezzoOptionals() { }

        public PrezzoOptionals(Double Valore, Double Ass)
        {
            this.Valore = Valore;
            this.Ass = Ass;
        }
    }
    public class Totale
    {
        public Double Valore { get; set; }
        public Double Ass { get; set; }

        public Totale() { }

        public Totale(Double Valore, Double Ass)
        {
            this.Valore = Valore;
            this.Ass = Ass;
        }
    }
    public class ListinoBase
    {
        public Double Imponibile { get; set; }
        public Double ImponibileIva { get; set; }
        public ListinoBase() { }
        public ListinoBase(Double Imponibile, Double ImponibileIva)
        {
            this.Imponibile = Imponibile;
            this.ImponibileIva = ImponibileIva;
        }
    }
    public class RitiroPrezzi
    {
        public Ritiro Ritiro { get; set; }
        public Prezzi Prezzi { get; set; }
        public RitiroPrezzi() { }
        public RitiroPrezzi(Ritiro Ritiro, Prezzi Prezzi)
        {
            this.Prezzi = Prezzi;
            this.Ritiro = Ritiro;
        }
    }

    public class Ritiro
    {
        public DateTime DataRitiro { get; set; }
        public string TipoRitiro { get; set; }

        public Ritiro() { }
        public Ritiro(DateTime DataRitiro, string TipoRitiro)
        {
            this.DataRitiro = DataRitiro;
            this.TipoRitiro = TipoRitiro;
        }
    }
    public class Prezzi
    {
        public Double ListinoBase { get; set; }
        public Double ListinoPrivilegiato { get; set; }
        public Double ListinoPrivilegiato2 { get; set; }

        public Prezzi() { }
        public Prezzi(Double ListinoBase, Double ListinoPrivilegiato, Double ListinoPrivilegiato2)
        {
            this.ListinoBase = ListinoBase;
            this.ListinoPrivilegiato = ListinoPrivilegiato;
            this.ListinoPrivilegiato2 = ListinoPrivilegiato2;
        }
    }
    public class FatturazioneConformita
    {
        public AssegnazioneFatturazione AssegnazioneFatturazione { get; set; }
        public FatturazioneConformita() { }
        public FatturazioneConformita(AssegnazioneFatturazione AssegnazioneFatturazione)
        {
            this.AssegnazioneFatturazione = AssegnazioneFatturazione;
        }
    }
    public class AssegnazioneFatturazione
    {
        public DateTime DataAssegnazFatturaz { get; set; }
        public DateTime DataArrivo { get; set; }
        public DateTime DataPrevistoRitiro { get; set; }
        public AssegnazioneFatturazione() { }
        public AssegnazioneFatturazione(DateTime DataAssegnazFatturaz, DateTime DataArrivo, DateTime DataPrevistoRitiro)
        {
            this.DataAssegnazFatturaz = DataAssegnazFatturaz;
            this.DataArrivo = DataArrivo;
            this.DataPrevistoRitiro = DataPrevistoRitiro;
        }
    }
    public class PrenotazioneVenditaConsegna
    {
        public Prenotazione Prenotazione { get; set; }
        public Vendita Vendita { get; set; }
        public Consegna Consegna { get; set; }

        public PrenotazioneVenditaConsegna() { }
        public PrenotazioneVenditaConsegna(Prenotazione Prenotazione, Vendita Vendita, Consegna Consegna)
        {
            this.Prenotazione = Prenotazione;
            this.Vendita = Vendita;
            this.Consegna = Consegna;
        }




    }
    public class Prenotazione
    {
        public Agente Agente { get; set; }
        public DateTime DataPrenotazion { get; set; }
        public DateTime DateScadenza { get; set; }
        public ClienteContatto ClienteContatto { get; set; }
        public string CfPiva { get; set; }
        public string Indirizzo { get; set; }
        public string Localita { get; set; }
        public string Provincia { get; set; }
        public int CAP { get; set; }
        public string Telefono { get; set; }
        public string Cellulare { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Contatto { get; set; }
        public string Note { get; set; }

        public Prenotazione() { }


        public Prenotazione(Agente Agente, DateTime DataPrenotazion, DateTime DateScadenza, ClienteContatto ClienteContatto, string CfPiva,
           string Indirizzo, string Localita, string Provincia, int CAP, string Telefono, string Cellulare, string Fax, string Email,
           string Contatto, string Note)
        {
            this.Agente = Agente;
            this.DataPrenotazion = DataPrenotazion;
            this.ClienteContatto = ClienteContatto;
            this.CfPiva = CfPiva;
            this.Indirizzo = Indirizzo;
            this.Localita = Localita;
            this.Provincia = Provincia;
            this.CAP = CAP;
            this.Telefono = Telefono;
            this.Cellulare = Cellulare;
            this.Fax = Fax;
            this.Email = Email;
            this.Contatto = Contatto;
            this.Note = Note;


        }

    }
    public class Agente
    {
        public int Codice { get; set; }
        public string Valore { get; set; }
        public DateTime DataPrenotazione { get; set; }
        public DateTime DataConsegna { get; set; }
        public Agente() { }
        public Agente(int Codice, string Valore, DateTime DataPrenotazione, DateTime DataConsegna)
        {
            this.Codice = Codice;
            this.Valore = Valore;
            this.DataPrenotazione = DataPrenotazione;
            this.DataConsegna = DataConsegna;
        }
    }
    public class ClienteContatto
    {
        public int Codice { get; set; }
        public string Valore { get; set; }
        public string Descrizione { get; set; }

        public ClienteContatto() { }
        public ClienteContatto(int Codice, string Valore, string Descrizione)
        {
            this.Codice = Codice;
            this.Valore = Valore;
            this.Descrizione = Descrizione;

        }

    }
    public class Vendita
    {
        public Contratto Contratto { get; set; }
        public string Agent { get; set; }
        public Cliente Cliente { get; set; }
        public string PIVA { get; set; }
        public string CCodiceFiscale { get; set; }
        public string Cfpiva { get; set; }
        public string Indirizzo { get; set; }
        public string Localita { get; set; }
        public string Provincia { get; set; }
        public int CAP { get; set; }
        public string Telefono { get; set; }

        public Acquirente Acquirente { get; set; }
        public string Concordato { get; set; }

        public Vendita() { }
        public Vendita(Contratto Contratto, string Agent, Cliente Cliente, string PIVA, string CCodiceFiscale, string Cfpiva, string Indirizzo, string Localita,
 string Provincia, int CAP, string Telefono, Acquirente Acquirente, string Concordato)
        {
            this.Contratto = Contratto;
            this.Agent = Agent;
            this.Cliente = Cliente;
            this.PIVA = PIVA;
            this.CCodiceFiscale = CCodiceFiscale;
            this.Cfpiva = Cfpiva;
            this.Indirizzo = Indirizzo;
            this.Localita = Localita;
            this.Provincia = Provincia;
            this.CAP = CAP;
            this.Telefono = Telefono;
            this.Acquirente = Acquirente;
            this.Concordato = Concordato;
        }

    }
    public class Contratto
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public DateTime Data { get; set; }

        public Contratto() { }

        public Contratto(string Tipo, int Numero, DateTime Data)
        {
            this.Tipo = Tipo;
            this.Numero = Numero;
            this.Data = Data;
        }
    }
    public class Cliente
    {
        public int Codice { get; set; }
        public string Valore { get; set; }

        public Cliente() { }
        public Cliente(int Codice, string Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;
        }
    }
    public class Acquirente
    {
        public string Codice { get; set; }
        public string Valore { get; set; }

        public Acquirente()
        {

        }
        public Acquirente(string Codice, string Valore)
        {
            this.Codice = Codice;
            this.Valore = Valore;
        }
    }
    public class Consegna
    {
        public DateTime DataRichiestaConsegna { get; set; }
        public DateTime DataImmatricolazione { get; set; }
        public DateTime DataRichiestaMapo { get; set; }

        public Consegna() { }
        public Consegna(DateTime DataRichiestaConsegna, DateTime DataImmatricolazione, DateTime DataRichiestaMapo)
        {
            this.DataRichiestaConsegna = DataRichiestaConsegna;
            this.DataImmatricolazione = DataImmatricolazione;
            this.DataRichiestaMapo = DataRichiestaMapo;
        }
    }
    public class StatusTrasportoDocumenti
    {
        public Status Status { get; set; }
        public DocumentoTrasporto DocumentoTrasporto { get; set; }
        public Anticipo Anticipo { get; set; }
        public List<Documentotem> ListaDocumenti { get; set; }

        public StatusTrasportoDocumenti()
        {

        }
        public StatusTrasportoDocumenti(Status Status, DocumentoTrasporto DocumentoTrasporto, Anticipo Anticipo, List<Documentotem> ListaDocumenti)
        {
            this.Status = Status;
            this.DocumentoTrasporto = DocumentoTrasporto;
            this.Anticipo = Anticipo;
            this.ListaDocumenti = ListaDocumenti;

        }
    }
    public class Status
    {
        public PrenotazioneStatus PrenotazioneStatus { get; set; }
        public ArrivoStatus ArrivoStatus { get; set; }

        public Status()
        {

        }
        public Status(PrenotazioneStatus PrenotazioneStatus, ArrivoStatus ArrivoStatus)
        {
            this.PrenotazioneStatus = PrenotazioneStatus;
            this.ArrivoStatus = ArrivoStatus;

        }
    }
    public class PrenotazioneStatus
    {
        public DateTime DataInizio { get; set; }
        public DateTime DataScadenza { get; set; }
        public string Note { get; set; }

        public PrenotazioneStatus()
        {

        }
        public PrenotazioneStatus(DateTime DataInizio, DateTime DataScadenza, string Note)
        {
            this.DataInizio = DataInizio;
            this.DataScadenza = DataScadenza;
            this.Note = Note;
        }
    }
    public class ArrivoStatus
    {
        public DateTime DataPrevistoArriv { get; set; }

        public DateTime DataArriv { get; set; }

        public ArrivoStatus()
        {

        }
        public ArrivoStatus(DateTime DataPrevistoArriv, DateTime DataArriv)
        {
            this.DataPrevistoArriv = DataPrevistoArriv;
            this.DataArriv = DataArriv;
        }

    }

    public class DocumentoTrasporto
    {
        public List<DDTItem> ListaDDT { get; set; }

        public DocumentoTrasporto()
        {

        }
        public DocumentoTrasporto(List<DDTItem> ListaDDT)
        {
            this.ListaDDT = ListaDDT;
        }

    }


    public class DDTItem
    {
        public int Tipo { get; set; }
        public string TipoMovimento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime DataDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string RagioneSociale { get; set; }
        public string CausaleTrasporto { get; set; }
        public string UbicazionePartenza { get; set; }
        public string UbicazioneDestinazione { get; set; }
        public string NoteDocumento { get; set; }

        public DDTItem()
        {

        }
        public DDTItem(int Tipo, string TipoMovimento, string TipoDocumento, DateTime DataDocumento, int NumeroDocumento, string RagioneSociale,
             string CausaleTrasporto, string UbicazionePartenza, string UbicazioneDestinazione, string NoteDocumento)
        {
            this.Tipo = Tipo;
            this.TipoMovimento = TipoMovimento;
            this.TipoDocumento = TipoDocumento;
            this.DataDocumento = DataDocumento;
            this.NumeroDocumento = NumeroDocumento;
            this.RagioneSociale = RagioneSociale;
            this.CausaleTrasporto = CausaleTrasporto;
            this.UbicazionePartenza = UbicazionePartenza;
            this.UbicazioneDestinazione = UbicazioneDestinazione;
            this.NoteDocumento = NoteDocumento;
        }

    }
    public class Anticipo
    {
        public DateTime DataPrevistoRitiroCDP { get; set; }

        public Anticipo()
        {

        }
        public Anticipo(DateTime DataPrevistoRitiroCDP)
        {
            this.DataPrevistoRitiroCDP = DataPrevistoRitiroCDP;
        }
    }

    public class Documentotem
    {
        public string Descrizione { get; set; }
        public string Categoria { get; set; }
        public string Note { get; set; }
        public string Check { get; set; }
        public string StatoArchiviazione { get; set; }

        public Documentotem()
        {

        }
        public Documentotem(string Descrizione, string Categoria, string Note, string Check, string StatoArchiviazione)
        {
            this.Descrizione = Descrizione;
            this.Categoria = Categoria;
            this.Note = Note;
            this.Check = Check;
            this.StatoArchiviazione = StatoArchiviazione;
        }



    }
}

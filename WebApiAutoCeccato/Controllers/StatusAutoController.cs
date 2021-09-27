using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiAutoCeccato.Kernel;

namespace WebApiAutoCeccato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<Autovettura> lista = new List<Autovettura>();
     
        public ValuesController()
        {

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Autovettura auto = new Autovettura();
                auto.ID = random.Next(0, 9);

                auto.Telaio = "ert";
                auto.Targa = "GML";
                auto.TipoAuto = "Corsa";

                AnagraficaVeicolo anagraficaVeicolo = new AnagraficaVeicolo();

                Marca marca = new Marca();
                marca.Codice = random.Next(0, 300);


                marca.Valore = FunctionManager.GetMarca();
                anagraficaVeicolo.Marca = marca;
                Modello modello = new Modello();
                modello.Codice = random.Next(0, 100);

                modello.Valore = random.Next(0, 78);

                anagraficaVeicolo.Modello = modello;

                Versione versione = new Versione();
                versione.Codice = random.Next(0, 3012);

                versione.Valore = "0UStreet";
                anagraficaVeicolo.Versione = versione;

                anagraficaVeicolo.Statut = FunctionManager.GetanagraficaVeicolo();
                anagraficaVeicolo.Descrizione = "Toyota";


                DatiVeicolo datiVeicolo = new DatiVeicolo();

                datiVeicolo.TipoVeicolo = "Sport";
                datiVeicolo.Omologazione = "sdfg";

                datiVeicolo.Cilindrata = FunctionManager.GetRandomNumber(1.23, 5.34);



                datiVeicolo.KmPercorsi = FunctionManager.GetRandomNumber(0.23, 6.34);


                DateTime ScadenzaBollo = new DateTime(2012, 02, 15);
                datiVeicolo.ScadenzaBollo = ScadenzaBollo;

                datiVeicolo.Alimentazione = "cavo";
                datiVeicolo.Trazione = "qasw";
                datiVeicolo.PotenzaKW = FunctionManager.GetRandomNumber(2.233, 10.3456);



                DateTime PrimImmatricolazione = new DateTime(2012, 02, 15);
                datiVeicolo.PrimImmatricolazione = PrimImmatricolazione;

                datiVeicolo.Carrozzeria = "renault";
                datiVeicolo.Cavalli = random.Next(0, 667);

                datiVeicolo.NumeroPosti = random.Next(0, 27);

                Colore colore = new Colore();
                colore.Codice = random.Next(0, 9983);
                colore.Valore = FunctionManager.GetColour();

                datiVeicolo.Linea = "WER";
                datiVeicolo.Ubicazione = "eryhg";
                datiVeicolo.Colore = colore;
                UbicazioneAttuale ubicazioneAttuale = new UbicazioneAttuale();
                ubicazioneAttuale.Codice = "kiu";
                ubicazioneAttuale.Valore = "venduto";
                datiVeicolo.UbicazioneAttuale = ubicazioneAttuale;
                datiVeicolo.DestinatoVendita = "giorgia";
                datiVeicolo.PremioAgente = FunctionManager.GetRandomNumber(4.233, 50.3456);

                anagraficaVeicolo.DatiVeicolo = datiVeicolo;

                Optionals optionals = new Optionals();
                optionals.Totale = FunctionManager.GetRandomNumber(2.233, 8.345);
                optionals.TotaleIva = FunctionManager.GetRandomNumber(2.533, 16.345);


                List<OptionalItem> ListaOptionals = new List<OptionalItem>();
                OptionalItem op = new OptionalItem();
                op.Codice = "acquistato";
                op.Descrizione = "tratazione";
                op.SerieRichiesto = "serie_A";
                op.Prezzo = FunctionManager.GetRandomNumber(5.233, 67.345);
                op.PrezzoIva = FunctionManager.GetRandomNumber(6.233, 98.356);
                op.Pack = 'c';
                ListaOptionals.Add(op);
                optionals.ListaOptionals = ListaOptionals;

                anagraficaVeicolo.Optionals = optionals;

                PrezzoVendita prezzoVendita = new PrezzoVendita();
                PrezzoVeicolo prezzoVeicolo = new PrezzoVeicolo();

                prezzoVeicolo.Valore = FunctionManager.GetRandomNumber(1.000, 10.345);
                prezzoVeicolo.Ass = FunctionManager.GetRandomNumber(3.000, 4.335);

                prezzoVendita.PrezzoVeicolo = prezzoVeicolo;
                PrezzoOptionals prezzoOptionals = new PrezzoOptionals();

                prezzoOptionals.Valore = FunctionManager.GetRandomNumber(2.233, 10.3456);
                prezzoOptionals.Ass = FunctionManager.GetRandomNumber(67.233, 80.3456);
                prezzoVendita.PrezzoOptionals = prezzoOptionals;


                Totale totale = new Totale();
                totale.Valore = FunctionManager.GetRandomNumber(2.233, 90.3456);
                totale.Ass = FunctionManager.GetRandomNumber(6.233, 25.3456);
                prezzoVendita.Totale = totale;
                ListinoBase listinoBase = new ListinoBase();

                listinoBase.Imponibile = random.Next(3, 567); ;
                listinoBase.ImponibileIva = random.Next(7, 571); ;
                prezzoVendita.ListinoBase = listinoBase;

                anagraficaVeicolo.PrezzoVendita = prezzoVendita;
                auto.AnagraficaVeicolo = anagraficaVeicolo;

                RitiroPrezzi ritiroPrezzi = new RitiroPrezzi();

                Ritiro ritiro = new Ritiro();
                DateTime DataRitiro = new DateTime(2012, 02, 15);
                ritiro.DataRitiro = DataRitiro;
                ritiro.TipoRitiro = "sbagliato";

                ritiroPrezzi.Ritiro = ritiro;

                Prezzi prezzi = new Prezzi();
                prezzi.ListinoBase = FunctionManager.GetRandomNumber(2.233, 90.555);
                prezzi.ListinoPrivilegiato = FunctionManager.GetRandomNumber(2.233, 90.3456);
                prezzi.ListinoPrivilegiato2 = FunctionManager.GetRandomNumber(2.233, 60.3456);

                ritiroPrezzi.Prezzi = prezzi;
                auto.RitiroPrezzi = ritiroPrezzi;

                FatturazioneConformita fatturazioneConformita = new FatturazioneConformita();
                AssegnazioneFatturazione assegnazioneFatturazione = new AssegnazioneFatturazione();
                DateTime DataAssegnazFatturaz = new DateTime(2012, 02, 15);
                assegnazioneFatturazione.DataAssegnazFatturaz = DataAssegnazFatturaz;
                DateTime DataArrivo = new DateTime(2012, 02, 15);
                assegnazioneFatturazione.DataArrivo = DataArrivo;
                DateTime DataPrevistoRitiro = new DateTime(2012, 02, 15);
                assegnazioneFatturazione.DataPrevistoRitiro = DataPrevistoRitiro;
                fatturazioneConformita.AssegnazioneFatturazione = assegnazioneFatturazione;
                auto.FatturazioneConformita = fatturazioneConformita;
                PrenotazioneVenditaConsegna prenotazioneVenditaConsegna = new PrenotazioneVenditaConsegna();
                Prenotazione prenotazione = new Prenotazione();
                Agente agente = new Agente();
                agente.Codice = random.Next(0, 2100);
                agente.Valore = "TOMSON";
                DateTime DataPrenotazione = new DateTime(2012, 02, 15);
                agente.DataPrenotazione = DataPrenotazione;
                DateTime DataConsegna = new DateTime(2012, 02, 15);
                agente.DataConsegna = DataConsegna;
                DateTime DataPrenotazion = new DateTime(2012, 02, 15);
                prenotazione.DataPrenotazion = DataPrenotazion;
                DateTime DateScadenza = new DateTime(2012, 02, 15);
                prenotazione.DateScadenza = DateScadenza;
                ClienteContatto clienteContatto = new ClienteContatto();

                clienteContatto.Codice = random.Next(0, 18889);
                clienteContatto.Valore = "Marco";
                clienteContatto.Descrizione = "Reccarti Allo Sportello";

                prenotazione.CfPiva = "TKX12IU907V";
                prenotazione.Indirizzo = "Via Doria 29";
                prenotazione.Localita = "Torino Est";
                prenotazione.Provincia = "Milano";
                prenotazione.CAP = random.Next(0, 11234);
                prenotazione.Telefono = "+39 3218263956";
                prenotazione.Cellulare = "011 011234567";
                prenotazione.Fax = "Avenue Guiget";
                prenotazione.Email = "antonio.possano@aubay.it";
                prenotazione.Contatto = "maurino";
                prenotazione.Note = "sono qui ti aspetto";

                Vendita vendita = new Vendita();
                Contratto contratto = new Contratto();
                contratto.Tipo = "occasionale";
                contratto.Numero = random.Next(0, 3219);
                DateTime Data = new DateTime(2012, 02, 15);
                contratto.Data = Data;
                vendita.Agent = "Sisal";
                Cliente cliente = new Cliente();
                cliente.Codice = random.Next(0, 63837);
                cliente.Valore = "SanPaolo";

                vendita.PIVA = "settore A";
                vendita.CCodiceFiscale = "TYUI87665JK";
                vendita.Cfpiva = "RT345";
                vendita.Indirizzo = "via rosa 4";
                vendita.Localita = "corso bramante";
                vendita.Provincia = "parma";
                vendita.CAP = random.Next(0, 23490);
                vendita.Telefono = "2345678901";
                Acquirente acquirente = new Acquirente();
                acquirente.Codice = "Xavier";
                acquirente.Valore = "s2304";
                vendita.Concordato = "pagato";
                Consegna consegna = new Consegna();
                DateTime DataRichiestaConsegna = new DateTime(2015, 08, 25);
                consegna.DataRichiestaConsegna = DataRichiestaConsegna;
                DateTime DataImmatricolazione = new DateTime(1015, 08, 15);
                consegna.DataImmatricolazione = DataImmatricolazione;
                DateTime DataRichiestaMapo = new DateTime(1089, 01, 10);
                consegna.DataRichiestaMapo = DataRichiestaMapo;
                StatusTrasportoDocumenti statusTrasportoDocumenti = new StatusTrasportoDocumenti();
                Status status = new Status();
                PrenotazioneStatus prenotazioneStatus = new PrenotazioneStatus();
                DateTime DataInizio = new DateTime(1011, 08, 11);
                prenotazioneStatus.DataInizio = DataInizio;
                DateTime DataScadenza = new DateTime(1011, 08, 11);
                prenotazioneStatus.DataScadenza = DataScadenza;
                prenotazioneStatus.Note = "scontato";
                ArrivoStatus arrivoStatus = new ArrivoStatus();
                DateTime DataPrevistoArriv = new DateTime(1011, 08, 01);
                arrivoStatus.DataPrevistoArriv = DataPrevistoArriv;
                DateTime DataArriv = new DateTime(1011, 08, 01);
                arrivoStatus.DataArriv = DataArriv;
                DocumentoTrasporto documentoTrasporto = new DocumentoTrasporto();

                List<DDTItem> ListaDDT = new List<DDTItem>();
                DDTItem dd = new DDTItem();
                dd.Tipo = random.Next(0, 3445);
                dd.TipoMovimento = "scarico";
                dd.TipoDocumento = "scaffale";
                DateTime DataDocumento = new DateTime(2015, 08, 25);
                dd.DataDocumento = DataDocumento;
                dd.NumeroDocumento = 123;
                dd.RagioneSociale = "mulsumano";
                dd.CausaleTrasporto = "visto";
                dd.UbicazionePartenza = "pomeriggio";
                dd.UbicazioneDestinazione = "torino";
                dd.NoteDocumento = "sospeso";

                ListaDDT.Add(dd);
                documentoTrasporto.ListaDDT = ListaDDT;

                Anticipo anticipo = new Anticipo();

                DateTime DataPrevistoRitiroCDP = new DateTime(2015, 08, 25);
                anticipo.DataPrevistoRitiroCDP = DataPrevistoRitiroCDP;

                List<Documentotem> ListaDocumenti = new List<Documentotem>();
                Documentotem documentotem = new Documentotem();

                documentotem.Descrizione = "soggiorno";
                documentotem.Categoria = "selvaggio";
                documentotem.Note = "quaranta";
                documentotem.Check = "comma";
                documentotem.StatoArchiviazione = "attesa";
                ListaDocumenti.Add(documentotem);


                status.ArrivoStatus = arrivoStatus;
                status.PrenotazioneStatus = prenotazioneStatus;
                statusTrasportoDocumenti.Status = status;
                statusTrasportoDocumenti.Anticipo = anticipo;
                statusTrasportoDocumenti.ListaDocumenti = ListaDocumenti;
                statusTrasportoDocumenti.DocumentoTrasporto = documentoTrasporto;

                prenotazioneVenditaConsegna.Prenotazione = prenotazione;
                prenotazioneVenditaConsegna.Consegna = consegna;

                prenotazioneVenditaConsegna.Vendita = vendita;
                vendita.Acquirente = acquirente;
                vendita.Cliente = cliente;
                vendita.Contratto = contratto;
                prenotazione.ClienteContatto = clienteContatto;
                prenotazione.Agente = agente;

                auto.PrenotazioneVenditaConsegna = prenotazioneVenditaConsegna;
                auto.StatusTrasportoDocumenti = statusTrasportoDocumenti;
                auto.FatturazioneConformita = fatturazioneConformita;


                lista.Add(auto);
            }

        }


        // GET api/Values
        [HttpGet]
        public List<Autovettura> Get()
        {
            return lista;
        }
        
        /*public ActionResult<IEnumerable<Autovettura>> Get()
        {  
        
            //return new string[] { "values1", "values2" };
        }
        */
        





        // GET api/values/5
       /* [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "values";
        }
       */ 
       /* public Autovettura Get(int id) {
            return lista.Where(x => x.ID == 4).FirstOrDefault();
        }*/


        // POST api/values
        [HttpPost]
       
        public void  Post(Autovettura autovettura)
        {
            lista.Add(autovettura);
            
        }

       // [HttpPost("{id}", Name = "Post")]
       
       /* public Autovettura  Post(int id)
        {
              for (int i = 0; i < 10; i++)
             {
              
              
                 if (lista[i].ID == id)
                 {
                   id = i;
                    
                }
             }
             return lista[id];
       
        }*/
       





        // PUT api/values/5
        [HttpPut("{id}")]
       public void Put(int id, [FromBody] Autovettura code)
        {
           
        }
    
       
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    
}

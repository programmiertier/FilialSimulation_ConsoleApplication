﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace FilialSimulation_ConsoleApplication
{
    internal class Regal
    {
        private int _regal_id;
        private double _regal_volumen = 1.0;
        private Artikel _artikel;
        private int _regal_kapazitaet;
        public double _regal_mindestBestand; // ist die kapazitaet * 0,3
        private int _regal_aktuellerInhalt;
        private bool _regal_nachfuellen;
        private double _regal_aktuellerWert;      // wie viel die aktuellen Waren, im Regal (natürlich... Peperoni) wert sind

        public int regal_id
        {
            get
            {
                return _regal_id;
            }
            set
            {
                _regal_id = value;
            }
        }
        public int regal_kapazitaet
        {
            get
            {
                return _regal_kapazitaet;
            }
            set
            {
                _regal_kapazitaet = value;
            }
        }

        public int regal_aktuellerInhalt
        {
            get
            {
                return _regal_aktuellerInhalt;
            }
            set
            {
                _regal_aktuellerInhalt = value;
            }
        }

        public double regal_aktuellerWert
        {
            get
            {
                return _regal_aktuellerWert;
            }
            set
            {
                _regal_aktuellerWert = value;
            }
        }
        public bool regal_nachfuellen
        {
            get
            {
                return _regal_nachfuellen;
            }
            set
            {
                _regal_nachfuellen = value;
            }
        }
        
        public Regal()
        {

        }
        
        public Regal(int id, Artikel[] wkatalog, double vol)
        {
            _regal_id = id;
            _regal_volumen = vol;
            _artikel = new Artikel(_regal_id, wkatalog);
            _regal_kapazitaet = (int)(_regal_volumen / _artikel.artikel_volumen);
            _regal_mindestBestand = (int)(_regal_kapazitaet * 0.3);
            regal_aktuellerInhalt = _regal_kapazitaet;
            regal_nachfuellen = regal_aktuellerInhalt <= _regal_mindestBestand;
            regal_aktuellerWert = regal_aktuellerInhalt * _artikel.artikel_preis;

            // WriteLine("Regal {0}\t:{1} Stück", regal_id, regal_kapazitaet);
            // WriteLine("Das Regal hat einen Wert von {0} Euro\n", regal_aktuellerWert);
        }

        public int[] fehlend(Raum blabla)
        {
            var fehltwas = from inhalt in blabla.regale
                           where _regal_nachfuellen == true
                           select _regal_id;
            foreach (int item in fehltwas)
            {
                WriteLine("{0}", item);
            }
            return fehltwas as int[];
        }

    }
}

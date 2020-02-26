using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntites;

namespace GUI
{
    public partial class SeUtskicksListaPersonal : Form
    {
        public BusinessManager BusinessManager { get; }
        public SeUtskicksListaPersonal(BusinessManager businessManager, UtskicksLista lista)
        {
            InitializeComponent();

            BusinessManager = businessManager;

            //IDLabel.Text = aktivitet.Id.ToString();
            //TitelLabel.Text = aktivitet.AktivitetNamn;
            //PlatserLabel.Text = aktivitet.AntalPlatser.ToString();
            //DatumLabel.Text = aktivitet.Datum.ToString();
            //TidLabel.Text = aktivitet.Tid;
            //PlatsLabel.Text = aktivitet.Plats;
            //BeskrivningBox.Text = aktivitet.Beskrivning;
        }
    }
}

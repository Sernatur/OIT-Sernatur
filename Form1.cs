/*--------------------------------------------------------------
 * Programa “SOFIA” Diseñado para Sernatur
 * 
 * Sistema Oficial de Informacion de Asesoramiento
 * 
 * Programador: Oliver Osvaldo Consterla Araya
 * Correo: Oliver_Consterla@Yahoo.cl
 * Numero movil: +56 9 87612427
 * 
 * Programa diseñado con fines de facilitar y ayudar
 * a la automatización de la atención a turista
 * y el cálculo estadísticos que estos pueden conllevar.
 ---------------------------------------------------------------*/

using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Security.Principal;
using System.Globalization;

namespace OIT_Sernatur
{
    public partial class Form1 : Form
    {
        IFormatProvider cultura = new CultureInfo("fr-FR");
        String FechaCorrecta,HoraCorrecta,Usuario,mensaje;
        int HoraDia;
        int Contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void horaDiariaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.horarioTableAdapter.HoraDiaria(this.sernatur_RegionalDataSet.Horario);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.Destino_Por_Regiones' Puede moverla o quitarla según sea necesario.
            this.destino_Por_RegionesTableAdapter.Fill(this.sernatur_RegionalDataSet.Destino_Por_Regiones);
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.Región' Puede moverla o quitarla según sea necesario.
            this.regiónTableAdapter.Fill(this.sernatur_RegionalDataSet.Región);
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.Experiencias' Puede moverla o quitarla según sea necesario.
            this.experienciasTableAdapter.Fill(this.sernatur_RegionalDataSet.Experiencias);
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.Tématica' Puede moverla o quitarla según sea necesario.
            this.tématicaTableAdapter.Fill(this.sernatur_RegionalDataSet.Tématica);
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.Horario' Puede moverla o quitarla según sea necesario.
            this.horarioTableAdapter.Fill(this.sernatur_RegionalDataSet.Horario);
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.Nacionalidad' Puede moverla o quitarla según sea necesario.
            this.nacionalidadTableAdapter.Fill(this.sernatur_RegionalDataSet.Nacionalidad);
            // TODO: esta línea de código carga datos en la tabla 'sernatur_RegionalDataSet.OIT' Puede moverla o quitarla según sea necesario.
            this.oITTableAdapter.Fill(this.sernatur_RegionalDataSet.OIT);


            NumCount.Text = Contador.ToString();
            OITBox.Text = "";
            RegiBox.Text = "";
            HomNum.Value = 0;
            MujNum.Value = 0;
            DestBox.SelectedIndex = 0;
            XperBox.SelectedIndex = 0;
            TematicaBox.SelectedIndex = 0;
            PaisBox.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Calendario.Value = DateTime.Now;
            Calendario.Format = DateTimePickerFormat.Custom;
            Calendario.CustomFormat = "dd/MM/yyyy";

            HoraDia = Calendario.Value.Hour;

            String selecteded = "SELECT Id, [Rango Hora], [Hora Final], [Hora Inicial] FROM Horario WHERE([Hora Inicial] <= " + HoraDia + ")";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (!(OITBox.Text == "") && !(PaisBox.Text == "") && (!(HomNum.Value == 0) || !(MujNum.Value == 0)))
            {
                ValueRange RangoValor = new ValueRange();
                RangoValor.MajorDimension = "ROWS";
                FechaCorrecta = new DateTime(Calendario.Value.Year, Calendario.Value.Month, Calendario.Value.Day).ToString("dd-MM-yyyy");
                HoraCorrecta = Calendario.Value.Hour.ToString() + ":" + Calendario.Value.Minute.ToString() + ":" + Calendario.Value.Second.ToString();



                var oblist = new List<object> { OITBox.Text, "", PaisBox.Text, HorarioBox.SelectedValue, FechaCorrecta, TematicaBox.SelectedValue, XperBox.SelectedValue, RegiBox.SelectedValue, DestBox.SelectedValue, HomNum.Value, MujNum.Value };
                RangoValor.Values = new List<IList<object>> { oblist };

                Contador = Contador + 1;
                NumCount.Text = Contador.ToString();

                SpreadsheetsResource.ValuesResource.AppendRequest request = Program.service.Spreadsheets.Values.Append(RangoValor, Program.spreadsheetId, Program.Range);
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                AppendValuesResponse resultadete = request.Execute();
                PaisBox.Text = "";
            }else if (OITBox.Text == "" && !(PaisBox.Text == ""))
            {
                mensaje = "El campo OIT es obligatorio";
                MessageBox.Show(mensaje);
                OITBox.Focus();

            }else if (PaisBox.Text == "" && !(OITBox.Text == ""))
            {
                mensaje = "El campo Nacionalidad es obligatorio";
                MessageBox.Show(mensaje);
                PaisBox.Focus();
            }else if ((HomNum.Value == 0) || (MujNum.Value == 0))
            {
                mensaje = "El campo Hombres o Mujeres debe ser mayor a 0";
                MessageBox.Show(mensaje);
                HomNum.Focus();
            }else
            {
                mensaje = "Los siguientes campos son obligatorios: \n  -OIT\n  -Nacionalidad";
                MessageBox.Show(mensaje);
                OITBox.Focus();
            }
        }





    }
}

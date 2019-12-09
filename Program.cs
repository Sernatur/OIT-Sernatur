/*--------------------------------------------------------------
 * Programa “SOFIA” Diseñado para Sernatur
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
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace OIT_Sernatur
{
    public class Program
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Sernatur Formulario OIT";
        public static string spreadsheetId = "1MAabjE1iwrYln2DjW0d4_VOy3UMWAdPdv4ChlcJRJzw";
        public static string sheet = "Atencion - Base";
        public static string Range = "Atencion - Base!A:Z";
        public static string sheet2 = "Turnos";
        public static string Range2 = "Turnos!A:Z";
        //static ValueRange RangoValor;
        public static SheetsService service;
        public static void Main()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json",FileMode.Open, FileAccess.Read))
            {
                String credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Archivo Credencial fue guardado en: " + credPath);
            }

            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            /*ValueRange RangoValor = new ValueRange();
            RangoValor.MajorDimension = "ROWS";


            var oblist = new List<object> { "famila consterla","","hermosa"};
            RangoValor.Values = new List<IList<object>> { oblist };

            SpreadsheetsResource.ValuesResource.AppendRequest request = service.Spreadsheets.Values.Append(RangoValor, spreadsheetId, Range);
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            AppendValuesResponse resultadete = request.Execute();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.WriteLine("Done!");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using v4._8_Sqlite_Tester.Models;
using SQLitePCL;

namespace v4._8_Sqlite_Tester
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                SqliteDbContext my_context = new SqliteDbContext();
                Debug.WriteLine("create complete, operation begin");
                Debug.WriteLine("DB created? : " + my_context.Database.EnsureCreated());

                //test write new data to db - WARNING: Ensure the Id value is unique ( with respect to the site table)
                /*
                var site = new Site { Id = 2, Notes = "New Site" };
                my_context.Sites.Add(site);
                my_context.SaveChanges();
                Debug.WriteLine("saved");
                */

                var sites = my_context.Sites.ToList();
                Debug.WriteLine("Fetch site data");

                foreach (var current_site in sites)
                {
                    Debug.WriteLine($"Site ID: {current_site.Id}, Notes: {current_site.Notes}");
                }

                //Winforms and DevExpress connection
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                

                //clean up
                my_context.Dispose();
            }
            catch (Exception ex) //debug caught exception
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message); //keeps all debug info open
            }
        }
    }
}

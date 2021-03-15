using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValheimCharacterEditor
{
    public partial class Form_Inventory : Form
    {
        public Form_Inventory()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form_Inventory_Load(object sender, EventArgs e)
        {
            // Populate forms with data
            _Populate();
        }

        private void _Populate()
        {

            foreach ( ValheimEngine.Character.Item item in  Customization.SelectedCharacter.Data.Inventory)
            {

               /* if (item.Name == "LeatherScraps")
                {
                    item.Stack = 50;
                }*/

                Dump(item);
            }

            try
            {

                // Make a backup of the selected character file
                if (!Util.BackupFile(Customization.SelectedCharacter.File))
                {
                    MessageBox.Show("Error while backing up character file.", "ERROR", MessageBoxButtons.OK);
                    return;
                }

                // Write customization, if fail restore backup
                if (Customization.WriteCustomization())
                {
                    //  MessageBox.Show("Customization applied.", "INFO", MessageBoxButtons.OK);
                    //  _Populate();
                    Console.WriteLine("updated");
                }
                else
                {
                    MessageBox.Show("There was an error while applying the new customization. Last backup will be restored.", "ERROR", MessageBoxButtons.OK);
                    Util.RestoreFile();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("There was an error while applying the new customization. Last backup will be restored.", "FATAL ERROR", MessageBoxButtons.OK);
                Util.RestoreFile();
            }




        }

        

    private static void Dump(object o)
        {
            string json = JsonConvert.SerializeObject(o, Formatting.Indented);
            Console.WriteLine(json);
        }


    }
}

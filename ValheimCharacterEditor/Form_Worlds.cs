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

    public partial class Form_Worlds : Form
    {
        private Customization.Character local_charater = new Customization.Character();
        public Form_Worlds()
        {
            InitializeComponent();
        }


        private void button_Exit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form_Worlds_Load(object sender, EventArgs e)
        {
            // Populate forms with data
            _Populate();
        }

        private void _Populate()
        {
           
            //worlds selector
            comboBox_worlds.DataSource = Util.GetCharacterWorlds(Customization.SelectedCharacter);
            comboBox_worlds.SelectedIndex = 0;

            //vectors           
            vector3_HomePoint.vector_name = "Home Point";
            vector3_HomePoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].HomePoint;
            if (Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].HasLogoutPoint)
            {
                vector3_LogoutPoint.vector_name = "Logout Point";
                vector3_LogoutPoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].LogoutPoint;
            }
            else
            {
                vector3_LogoutPoint.vector_name = "No Logout Point";
                vector3_LogoutPoint.vector3 = new ValheimEngine.Vector3();
                vector3_LogoutPoint.disable = true;
            }
            if (Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].HasCustomSpawnPoint)
            {
                vector3_SpawnPoint.vector_name = "Spawn Point";
                vector3_SpawnPoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].SpawnPoint;
            }
            else
            {
                vector3_SpawnPoint.vector_name = "No Custom Spawn Point";
                vector3_SpawnPoint.vector3 = new ValheimEngine.Vector3();
                vector3_SpawnPoint.disable = true;
            }
            if (Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].HasDeathPoint)
            {

                vector3_DeathPoint.vector_name = "Death Point";
                vector3_DeathPoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].DeathPoint;
                vector3_DeathPoint.disable = true;
            }
            else
            {
                vector3_DeathPoint.vector_name = "No DeathPoint";
                vector3_DeathPoint.vector3 = new ValheimEngine.Vector3();
                vector3_DeathPoint.disable = true;
            }


        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (Util.SaveCharacter())
            {
                _Populate();
            }
        }

        private void Form_Worlds_FormClosing(object sender, FormClosingEventArgs e)
        {
            //clear out changes before form exit to avoid save on a diffrent form 
            Util.ReloadCharaters();

        }

        private void button_set_LP_DP_Click(object sender, EventArgs e)
        {
            vector3_LogoutPoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].DeathPoint;
            _Populate();
        }

        private void button_set_LP_SP_Click(object sender, EventArgs e)
        {
            vector3_LogoutPoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].SpawnPoint;
            _Populate();

        }

        private void button_set_LP_HP_Click(object sender, EventArgs e)
        {
            vector3_LogoutPoint.vector3 = Customization.SelectedCharacter.Data.WorldsData[long.Parse(comboBox_worlds.SelectedItem.ToString())].HomePoint;
            _Populate();
        }
    }
}


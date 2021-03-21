using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace ValheimCharacterEditor.Controls
{

    public partial class Vector3_Control : UserControl
    {
        private ValheimEngine.Vector3 vector;

        public string vector_name
        {
            get
            {
                return Group_Vector3.Text;
            }
            set
            {
                Group_Vector3.Text = value;

            }
        }
        public bool disable
        {
           
            set
            {
                textBox_X.Enabled = false;
                textBox_Y.Enabled = false;
                textBox_Z.Enabled = false;

            }
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ValheimEngine.Vector3 vector3
        {
            get
            {
                var new_vector = new ValheimEngine.Vector3();
                new_vector.X = long.Parse(textBox_X.Text.ToString());
                new_vector.Y = long.Parse(textBox_Y.Text.ToString());
                new_vector.Z = long.Parse(textBox_Z.Text.ToString());
                return new_vector;
            }
            
            set
            {
                       
                textBox_X.Text = value.X.ToString();
                textBox_Y.Text = value.Y.ToString();
                textBox_Z.Text = value.Z.ToString();
                vector = value;
                
            }
        }

        public Vector3_Control()
        {
            InitializeComponent();
        }

        private void Vector_name_Enter(object sender, EventArgs e)
        {
            var _vector = new ValheimEngine.Vector3();

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vector.X = float.Parse(textBox_X.Text.ToString());
                vector.Y = float.Parse(textBox_Y.Text.ToString());
                vector.Z = float.Parse(textBox_Z.Text.ToString());
            }
            catch(NullReferenceException)
            {
                return;

            }
        }
    }
}

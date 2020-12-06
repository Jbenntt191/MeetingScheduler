using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public partial class formScheduler : Form
    {
        public formScheduler()
        {
            InitializeComponent();
        }

        public void clearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Value = DateTime.Now;
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                else
                    clearAllText(c);
            }

            listResults1.Items.Clear();
            listResults2.Items.Clear();
            listResults3.Items.Clear();
            // Test lol
        }

        public void foundMeeting()
        {
            MessageBox.Show("We found you a meeting date:" + "\n\n" + "DATE HERE" + "\n\n" + "The meeting host is " + txtMeetingHost);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllText(this);
        }
    }
}

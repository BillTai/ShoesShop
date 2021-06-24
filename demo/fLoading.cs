using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class fLoading : Form
    {
        public fLoading()
        {
            InitializeComponent();
        }
        private void fLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 2900;
            timer1.Enabled = true;
            mdaVideo.URL = Path.GetFullPath("loading") + @"\loadingvideo.mp4";
            mdaVideo.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval == 2900)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Connect ConnectSQL = new Connect();
                DataTable Account = new DataTable();
                Account = ConnectSQL.ExcuteQuery("Select IDStaff, Status from Account");
                bool CheckAccountOnline()
                {
                    bool Flag = false;
                    if (Account.Rows.Count >= 1)
                    {
                        for (int i = 0; i < Account.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(Account.Rows[i][1]) == 1)
                            {
                                Flag = true;
                                break;
                            }
                        }

                    }
                    return Flag;
                }

                if (CheckAccountOnline())
                {
                    string IDStaff = "";
                    for (int i = 0; i < Account.Rows.Count; i++)
                    {
                        if (Account.Rows[i][1].ToString() == "1")
                        {
                            IDStaff = Account.Rows[i][0].ToString();
                        }
                    }
                    this.Hide();
                    fHomePage fhp = new fHomePage();
                    fhp.ShowDialog();
                    this.Close();
                }
                else
                {

                    this.Hide();
                    fLogin flog = new fLogin();
                    flog.ShowDialog();
                    this.Close();
                }

            }    
        }


    }
}

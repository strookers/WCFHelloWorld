using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelloWinForm.RemoteHelloReference;

namespace HelloWinForm
{
    public partial class Form1 : Form
    {
        private RemoteHelloReference.IHelloService helloObj = new HelloServiceClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            rTxt.Text = helloObj.SayHello();
        }
    }
}
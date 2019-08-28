using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWebBrowserControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.webBrowser1.Url = new Uri("https://www.microsoft.com");
        }
    }
}

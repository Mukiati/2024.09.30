using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._09._30
{
    public partial class Form1 : Form
    {
        databasehandler db;
        public Form1()
        {
            InitializeComponent();
            db = new databasehandler();
            db.ReadAll();
        }
    }
}

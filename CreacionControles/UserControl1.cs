using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreacionControles
{
    public partial class UserControl1 : UserControl
    {

        private String ClaveUsuario;

        public String getClaveUsuario()
        {
            return ClaveUsuario;
        }

        public UserControl1()
        {
            InitializeComponent();
        }
    }
}

using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datetimepickeradv_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DateTimePickerAdv dateTimePickerAdv = new DateTimePickerAdv();
            dateTimePickerAdv.Location = new Point(100, 100);
            dateTimePickerAdv.ShowUpDown = true;
            dateTimePickerAdv.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(dateTimePickerAdv);
        }
    }
}

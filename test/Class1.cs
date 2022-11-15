using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Forms;
using System.ComponentModel;

namespace test
{
    class Class1 : Button
    {
        private bool gigante = true;

        [Description("Una descripcion re copada")]
        [Category("CosasGigante")]
        [DefaultValue(true)] 
        public bool Gigante {
            get { return gigante; }
            set { gigante = value; }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (gigante)
                this.Size = new System.Drawing.Size(150, 150);
            base.OnMouseEnter(e);
        }
    }
}

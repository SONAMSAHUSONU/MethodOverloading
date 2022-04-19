using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public partial class Method_reveson : Component
    {
        public Method_reveson()
        {
            InitializeComponent();
        }

        public Method_reveson(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitKing.Classes.db
{
    public partial class config : Component
    {
        public config()
        {
            InitializeComponent();
        }

        public config(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

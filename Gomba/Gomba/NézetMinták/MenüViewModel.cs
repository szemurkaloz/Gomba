using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace Gomba
{
    [Export(typeof(MenüViewModel))]
    public class MenüViewModel : PropertyChangedBase
    {
        readonly IWindowManager windowManager;
        private XmlNodeItem megfogottMenüsor;

        [ImportingConstructor]
        public MenüViewModel(IWindowManager windowManager)
        {
            this.windowManager = windowManager;
        }

        public XmlNodeItem MegfogottMenüsor
        {
            get { return megfogottMenüsor; }
            set
            {
                if (megfogottMenüsor != value)
                {
                    megfogottMenüsor = value;
                    NotifyOfPropertyChange(() => MegfogottMenüsor);
                }
            }
        }

        public void RadTreeView_MouseDoubleClick(object sender)
        {
            Debug.WriteLine("Menüre kattintott");
            Telerik.Windows.Controls.RadTreeView rtv = sender as RadTreeView;
            XmlNodeItem akt = rtv.SelectedItem as XmlNodeItem;
            Debug.WriteLine(akt.Tag);
            if ((akt.Tag == null) || (akt.Tag == string.Empty)) { return; }
            switch (akt.Tag)
            {
                case "Gombaszedők":
                    windowManager.ShowWindow(new DolgozókViewModel());
                    break;
                case "1":
                    Console.WriteLine("Case 2");
                    break;
            }
            
        }
    }
}

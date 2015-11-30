using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomba
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Screen, IShell
    {
        readonly IWindowManager windowManager;
        private readonly IEventAggregator eventAggregator;

        [ImportingConstructor]
        public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator, MenüViewModel menüViewModel)
        {
            this.windowManager = windowManager;
            this.eventAggregator = eventAggregator;
            Menü = menüViewModel;
        }

        public MenüViewModel Menü { get; private set; }

        public void OpenModal()
        {
            //windowManager.ShowWindow(new ComPortBeállításViewModel(eventAggregator));
        }

        public void OpenMérésAblak()
        {
            //windowManager.ShowWindow(new MérésViewModel());
        }
    }
}

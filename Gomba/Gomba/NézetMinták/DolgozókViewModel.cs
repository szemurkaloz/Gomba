using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Adattárolás.Táblák;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System.Diagnostics;

namespace Gomba
{
    [Export(typeof(DolgozókViewModel))]
    class DolgozókViewModel : Screen
    {
        private IObservableCollection<Dolgozó> dolgozókLista; 

        [ImportingConstructor]
        public DolgozókViewModel()
        {
          
        }
        
        #region Tulajdonságok
        public IObservableCollection<Dolgozó> DolgozókLista
        {
            get { return dolgozókLista; }
            set
            {
                if (dolgozókLista != value)
                {
                    dolgozókLista = value;
                    NotifyOfPropertyChange(() => DolgozókLista);
                }
            }
        }
        #endregion Tulajdonságok

        #region Eljárások

        protected override void OnInitialize()
        {
            using (var db = IoC.Get<IDbConnectionFactory>().Open())
            {
                //
                    var lista = db.Select<Dolgozó>().OrderBy(a => a.Név).ToList();
                dolgozókLista = new BindableCollection<Dolgozó>(lista);
                Debug.WriteLine(string.Format("Lista számossága:{0}",dolgozókLista.Count));
            }
        
        }

        #endregion Eljárások
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.Capawcino.UIExtra.Controls
{
    public enum Views
    {
        Sales,Products,Clients,Business,Statistics
    }

    public class ViewFactory
    {
        public BaseControl GetView(Views view)
        {
            switch (view)
            {
                case Views.Sales:
                    return new SalesView();
                case Views.Products:
                    return new ProductsView();
                case Views.Clients:
                    return new ClientsView();
                case Views.Business:
                    return new BusinessView();
                case Views.Statistics:
                    return new StatisticsView();
                default:
                    return new BaseControl();
            }
        }

        public BaseControl GetView(string viewName)
        {
            Enum.TryParse(viewName, true, out Views views);
            return GetView(views);

        }

    }
}

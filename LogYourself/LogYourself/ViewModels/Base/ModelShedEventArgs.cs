using SelfMonitoringApp.Models;
using SelfMonitoringApp.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogYourself.ViewModels.Base
{
    public class ModelShedEventArgs :EventArgs
    {
        public IModel EventModel { get; private set; }
        public ModelShedEventArgs(IModel model)
        {
            EventModel = model;
        }
    }
}

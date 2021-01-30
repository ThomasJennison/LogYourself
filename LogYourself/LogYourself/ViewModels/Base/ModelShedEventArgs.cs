using LogYourself.Models;
using LogYourself.Models.Base;
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

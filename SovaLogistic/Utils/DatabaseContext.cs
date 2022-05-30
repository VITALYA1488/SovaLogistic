using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SovaLogistic.Models;
using SovaLogistic.Views.PartialViews;
using SovaLogistic.Views;

namespace SovaLogistic.Utils
{
    class DatabaseContext
    {
        public static ModelLogistic db = new ModelLogistic();
    }
}

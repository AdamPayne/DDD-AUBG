﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repositories
{
    interface IHallRepository
    {
        Hall RetrieveHall(int number);
        void SaveHall();
    }
}

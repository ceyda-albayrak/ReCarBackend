﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework.Abstract;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService:IService<Car>
    {
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailsDTOs>> GetCarDetails();

    }
}

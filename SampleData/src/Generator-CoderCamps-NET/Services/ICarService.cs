using System.Collections.Generic;
using Generator_CoderCamps_NET.Models;

namespace Generator_CoderCamps_NET.Services
{
    public interface ICarService
    {
        Car FindCar(int id);
        IEnumerable<Car> ListCars();
        IEnumerable<CarMake> ListMakes();
    }
}
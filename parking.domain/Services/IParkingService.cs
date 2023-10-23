using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parking.domain.Entities;

namespace parking.domain.Services
{
    public interface IParkingService
    {
        void Create(ParkingObject parkingObject);

        void Create(Agreement agreement);

        void CloseParking(ParkingObject parkingObject);

        void CloseParking(Agreement agreement);

    }
}
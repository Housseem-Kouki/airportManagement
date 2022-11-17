using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filtervalue);
        void showFlighhtDetails(Plane plane);

        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        List<Flight> OrderedDurationFlights();
        IEnumerable<IGrouping<String, Flight>> DestinationGroupFlight();
        
      //  IEnumerable<Traveller> SeniorTravellers(Flight flight);

    }
}

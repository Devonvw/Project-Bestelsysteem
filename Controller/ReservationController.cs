using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Controller
{
    public class ReservationController
    {
        ReservationDao reservationDB;

        public ReservationController()
        {
            reservationDB = new ReservationDao();
        }

        public List<Reservation> GetAllReservations()
        {
            return reservationDB.GetAllReservations();
        }

        public void AddReservation(Reservation reservation)
        {
            reservationDB.AddReservation(reservation);
        }
        public List<Reservation> GetReservationByName(Reservation reservation)
        {
            return reservationDB.GetReservationByName(reservation);
        }
        public List<Reservation> GetReservationsForTable(Reservation reservation)
        {
            return reservationDB.GetReservationsForTable(reservation);
        }
        public List<Reservation> GetReservationByTime(Reservation reservation)
        {
            return reservationDB.GetReservationByTime(reservation);
        }
        public void DeleteReservation(Reservation reservation)
        {
            reservationDB.DeleteReservation(reservation);
        }
    }
}

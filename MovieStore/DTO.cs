﻿using System;
using System.Collections.Generic;

namespace MovieUniversal
{
    public class clsGenre

    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }

        public List<clsAllMovie> MovieList { get; set; }

    }

    public class clsAllMovie
    {
        public int MovieID { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public DateTime DateTimeModified { get; set; }
        public bool Available { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Rentable { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? Discount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t ${1}\t {2}", Title, Price, Available);
        }
    }
    public class clsOrder
    {
        public int OrderID { get; set; }
        public int MovieID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}", OrderID, MovieID, Quantity, Price, Date, CustomerName, CustomerAddress);
        }
    }
}

﻿using StatePrinting;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Media.Imaging;
using TravelApp.Models.TeleportWebApiModels;
using TravelApp.Services;

namespace TravelApp.Models.EntityModels
{
    public class TripEntity : IComparable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public DateTime DepartmentDateTime { get; set; }
        public String TripAim { get; set; }

        public TeleportSearchedCityDistrictModel FromSearchedCityDistrictModel { get; set; }
        public TeleportSearchedCityDistrictModel ToSearchedCityDistrictModel { get; set; }

        public long UserEntityId { get; set; }

        [NotMapped]
        public BitmapImage destinationCityImage;
        [NotMapped]
        public BitmapImage DestinationCityImage
        {
            get
            {
                return destinationCityImage;
            }
            set
            {
                destinationCityImage = value;
            }
        }

        [NotMapped]
        public string ArrivalDateTimeString {
            get
            {
                return ArrivalDateTime.ToString("dd.MM.yyyy");
            }
        }

        [NotMapped]
        public string DepartmentDateTimeString
        {
            get
            {
                return DepartmentDateTime.ToString("dd.MM.yyyy");
            }
        }

        [NotMapped]
        private ITeleportDestination_sCategoriesScoresImagesService iTeleportDestination_SCategoriesScoresImagesService;

        public TripEntity()
        {
            iTeleportDestination_SCategoriesScoresImagesService = iTeleportDestination_SCategoriesScoresImagesService = new TeleportDestination_sCategoriesDetailsImagesServiceWebApi();
        }

        public int CompareTo(object obj)
        {
            return Id.CompareTo((obj as TripEntity).Id);
        }

        // Nice stuff ahead!
        static readonly Stateprinter printer = new Stateprinter();
        public override string ToString()
        {
            return printer.PrintObject(this);
        }
    }
}